using PlayLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TestWPFPlay
{
    [Export(typeof(IPlayApp))]
    public class Launcher : IPlayApp
    {
        public CategoryType Category { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool Mode { get; set; }
        public string Name { get; set; }
        public TechnologyType Technology { get; set; }
        public Bitmap Thumbnail { get; set; }
        public string Version { get; set; }

        public Launcher()
        {
            Category = CategoryType.Project;
            Date = new DateTime(2014, 01, 10);
            Description = "Description projet";
            Mode = true;
            Name = "Nom projet";
            Technology = TechnologyType.CSharp;
            Version = "1.0";
            Thumbnail = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("TestWPFPlay.Images.thumbnail.png"));
        }
        
        public bool LaunchApp()
        {
            //Try catch sur l'ouverture pour éviter une erreure d'initialisation
            try
            {
                MainWindow window = new MainWindow();
                return true;
            }
            catch (Exception)
            {
                return false;
            } 
        }

    }
}
