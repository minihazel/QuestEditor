using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QuestEditor
{
    public partial class mainForm : Form
    {
        public string path = $"F:\\SPT Iterations\\SPT 3.5.4\\user\\profiles\\da94bdf841ee410c634c7428.json";
        public string path2 = $"F:\\SPT Iterations\\SPT 3.5.4\\Aki_Data\\Server\\database\\templates\\quests.json";

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            questBox.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool pathExists = File.Exists(path2);
            if (pathExists)
            {
                string readPath = File.ReadAllText(path2);
                dynamic readQuests = JsonConvert.DeserializeObject(readPath);

                List<string> foundQuests = new List<string>();
                int matchingQuests = 0;

                int questCounter = 0;
                int playerQuestCounter = 0;

                foreach (JProperty obj in readQuests)
                {
                    questCounter++;

                    string questName = obj.Value["QuestName"].ToString();
                    Debug.WriteLine(questName);
                    if (questName.ToLower().Contains(searchBox.Text.ToLower()))
                    {
                        matchingQuests++;
                        foundQuests.Add(questName);
                    }
                }

                if (questCounter > 0)
                {
                    MessageBox.Show($"Success; {matchingQuests} quests found that match your name:\n\n{string.Join(", ", foundQuests)}");
                }
                /*
                string readPath2 = File.ReadAllText(path);
                dynamic readQuests2 = JsonConvert.DeserializeObject(readPath2);

                foreach (var obj in readQuests2["characters"]["pmc"]["Quests"])
                {
                }
                */
            }
            else
            {
                MessageBox.Show("Path does not exist");
            }
        }

        private void bCheckActiveQuests_Click(object sender, EventArgs e)
        {

            List<string> foundQuests = new List<string>();

            string readPath = File.ReadAllText(path);
            dynamic readQuests = JsonConvert.DeserializeObject(readPath);

            string readPath2 = File.ReadAllText(path2);
            JObject readQuestsTemplate = JObject.Parse(readPath2);

            JArray questArray = (JArray)readQuests["characters"]["pmc"]["Quests"];

            foreach (JObject obj in questArray)
            {
                int questId = obj.Value<int>("status");
                string questName = obj.Value<string>("qid");

                if (questId == 2 && questId != 4 && questName != null)
                {
                    var matchedQuest = readQuestsTemplate[questName];
                    if (matchedQuest != null)
                    {
                        if ((string)matchedQuest["QuestName"] != null)
                        {
                            string matchedName = (string)matchedQuest["QuestName"];
                            // Debug.WriteLine($"Quest {obj.Value<string>("qid")} ({matchedName}) has Started");
                            activeQuestsList.Items.Add($"{obj.Value<string>("qid")}  ({matchedName})");
                        }
                    }
                }
            }
        }

        private void activeQuestsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activeQuestsList.SelectedIndex > -1)
            {
                questOptionsBox.Visible = true;

                fetchQuestInfo(activeQuestsList);
            }
        }

        public void fetchQuestInfo(ListBox c)
        {
            questStatusValue.Value = 0;
            string readPath = File.ReadAllText(path);
            dynamic readQuests = JsonConvert.DeserializeObject(readPath);

            JArray questArray = (JArray)readQuests["characters"]["pmc"]["Quests"];
            string selectedQuest = c.Text.ToString().Substring(0, 24);

            foreach (JObject obj in questArray)
            {
                string questName = obj.Value<string>("qid");

                if (questName == selectedQuest.ToLower() && questName != null)
                {
                    int questId = obj.Value<int>("status");
                    questStatusValue.Value = questId;
                }
            }
        }

        private void bQuestFinishOption_Click(object sender, EventArgs e)
        {
            finishQuest(activeQuestsList);
        }

        public void finishQuest(ListBox c)
        {
            string selectedQuest = c.Text.ToString().Substring(0, 24);
            if (selectedQuest != null)
            {
                string readPath = File.ReadAllText(path);
                dynamic readQuests = JsonConvert.DeserializeObject(readPath);

                JArray questArray = (JArray)readQuests["characters"]["pmc"]["Quests"];
                JToken quest = questArray.FirstOrDefault(q => (string)q["qid"] == selectedQuest);

                if (quest != null)
                {
                    quest["status"] = 3;
                    string updatedProfile = JsonConvert.SerializeObject(readQuests, Formatting.Indented);
                    File.WriteAllText(path, updatedProfile);
                }
                else
                {
                    MessageBox.Show($"We could not find a quest with ID of {selectedQuest}.", this.Text, MessageBoxButtons.OK);
                }
            }
        }
    }
}
