using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Xml;
using System.Xml.Serialization;
using me.coldandtired.mcg.Models;

namespace me.coldandtired.mcg
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = MainPage.mobs;
        }

        public string serialize_mobs(Mobs mobs)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(mobs.GetType());

            XmlWriterSettings ws = new XmlWriterSettings();
            ws.Encoding = System.Text.Encoding.UTF8;
            ws.Indent = true;
            StringBuilder output = new StringBuilder();
            XmlWriter xmlWriter = XmlWriter.Create(output, ws);
            serializer.Serialize(xmlWriter, mobs);
            return output.ToString();
        } 

        private void save(object sender, RoutedEventArgs e)
        {
            string xml = serialize_mobs(MainPage.mobs);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = ".mobs";
            dialog.Filter = "Mobs data files|*.mobs";
            dialog.DefaultFileName = "ttt.mobs";
            if (dialog.ShowDialog() == true)
            {
                using (Stream stream = dialog.OpenFile())
                {
                    StreamWriter sw = new StreamWriter(stream, Encoding.Unicode);
                    sw.Write(xml);
                    sw.Close();

                    stream.Close();
                }
            }
        }

        private void load(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Mobs data files|*.mobs";
            if (dialog.ShowDialog() == true)
            {
                FileStream fs = dialog.File.OpenRead();
                StreamReader sr = new StreamReader(fs);
                XmlSerializer serializer = new XmlSerializer(typeof(Mobs));

                MainPage.mobs = (Mobs)serializer.Deserialize(sr);
                DataContext = MainPage.mobs;
                foreach (Mob m in MainPage.mobs.mob_pool)
                {

                }
                sr.Close();
                fs.Close();
            }
        }              
    }
}