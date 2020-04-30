﻿using Syncfusion.UI.Xaml.Kanban;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Started
{
    public class TaskDetails
    {
        public TaskDetails()
        {

            Tasks = new ObservableCollection<KanbanModel>();

            Tasks.Add(new KanbanModel()
            {

                Title = "Universal App",

                ID = "27654",

                Description = "Incorporate feedback into functional specifications",

                Category = "Open",

                ColorKey = "Low",

                Tags = new string[] { "Deployment" },

                ImageURL = new Uri("ms-appx:///images/People_Circle1.png")
            });


            Tasks.Add(new KanbanModel()
            {

                Title = "Universal App",

                ID = "29477",

                Description = "Design functional specifications",

                Category = "In Progress",

                ColorKey = "Normal",

                Tags = new string[] { "Design" },

                ImageURL = new Uri("ms-appx:///images/People_Circle2.png")
            });


            Tasks.Add(new KanbanModel()
            {
                Title = "Universal App",

                ID = "25678",

                Description = "Review preliminary software specifications",

                Category = "Done",

                ColorKey = "Low",

                Tags = new string[] { "Analysis" },

                ImageURL = new Uri("ms-appx:///images/People_Circle3.png")
            });


            Tasks.Add(new KanbanModel()
            {
                Title = "Universal App",

                ID = "6593",

                Description = "Draft preliminary software specifications",

                Category = "Review",

                ColorKey = "High",

                Tags = new string[] { "Analysis" },

                ImageURL = new Uri("ms-appx:///images/People_Circle4.png")

            });
        }
        public ObservableCollection<KanbanModel> Tasks { get; set; }
    }
}
