using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlenderBot.Properties;
using System.Windows.Forms;

namespace BlenderBot.Scripts
{
    class Args
    {

        public static StartupForm _StartupForm = Application.OpenForms.Cast<StartupForm>().FirstOrDefault(c => c is StartupForm);
        public static string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static string[] Get()
        {
            if (File.Exists(docs + @"\BlenderBot\prefs.cfg"))
            {
                string[] prefs = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BlenderBot\prefs.cfg");
                prefs[0] = prefs[0].Split('=').Skip(1).FirstOrDefault();
                prefs[1] = prefs[1].Split('=').Skip(1).FirstOrDefault();
                prefs[2] = prefs[2].Split('=').Skip(1).FirstOrDefault();
                prefs[3] = prefs[3].Split('=').Skip(1).FirstOrDefault();
                prefs[4] = prefs[4].Split('=').Skip(1).FirstOrDefault();

                return prefs;
            }
			else if (Directory.Exists(docs + @"\Blenderbot"))
            {
                File.Copy(@"Resources\prefs.cfg",Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BlenderBot\prefs.cfg");
                string[] prefs = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BlenderBot\prefs.cfg");
                prefs[0] = prefs[0].Split('=').Skip(1).FirstOrDefault();
                prefs[1] = prefs[1].Split('=').Skip(1).FirstOrDefault();
                prefs[2] = prefs[2].Split('=').Skip(1).FirstOrDefault();
                prefs[3] = prefs[3].Split('=').Skip(1).FirstOrDefault();
                prefs[4] = prefs[4].Split('=').Skip(1).FirstOrDefault();

                return prefs;
            }
			else
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BlenderBot");
                File.Copy(@"Resources\prefs.cfg", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BlenderBot\prefs.cfg");
                string[] prefs = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BlenderBot\prefs.cfg");
                prefs[0] = prefs[0].Split('=').Skip(1).FirstOrDefault();
                prefs[1] = prefs[1].Split('=').Skip(1).FirstOrDefault();
                prefs[2] = prefs[2].Split('=').Skip(1).FirstOrDefault();
                prefs[3] = prefs[3].Split('=').Skip(1).FirstOrDefault();
                prefs[4] = prefs[4].Split('=').Skip(1).FirstOrDefault();

                return prefs;
            }


        }

        public static void Set(string[] prefs)
        {
            prefs[0] = "BlenderExecutable=" + prefs[0];
            prefs[1] = "ProjectFolder=" + prefs[1];
            prefs[2] = "ChannelID=" + prefs[2];
            prefs[3] = "ImageFormat=" + prefs[3];
            prefs[4] = "AnimationFormat=" + prefs[4];
            File.WriteAllLines(docs + @"\Blenderbot\prefs.cfg", prefs);
        }

        public static object[] Append(string[] prefs, string name, string frame)
        {
            Console.WriteLine($"{prefs[0]} | {prefs[1]} | {prefs[2]} | {prefs[3]}");
            object[] _return = new object[3];
            if (prefs[3] == "Use Blender Configuration")
            {
                _return[0] = $"/c {Char.ToString('"') + Char.ToString('"') + prefs[0] + Char.ToString('"')} {Char.ToString('"') + prefs[1] + name}.blend{Char.ToString('"')} -b -o //{name} -f {frame + Char.ToString('"')}";
                Console.WriteLine(_return[0]);
            }
            else
            {
                _return[0] = $"/c {Char.ToString('"') + Char.ToString('"') + prefs[0] + Char.ToString('"')} {Char.ToString('"') + prefs[1] + name}.blend{Char.ToString('"')} -b -o //{name} -F {prefs[3]} -f {frame + Char.ToString('"')}";
                Console.WriteLine(_return[0]);
            }
            _return[1] = prefs[2];
            _return[2] = Token._Token();
            return _return;
        }

        internal static string Preview(string PDir, string Format, string Frame, string Name)
        {

            
            switch (Frame.Length)
            {
                case 1:
                    Frame = $"000{Frame}";
                    break;
                case 2:
                    Frame = $"00{Frame}";
                    break;
                case 3:
                    Frame = $"0{Frame}";
                    break;
                default:
                    break;
            }
            var inf = new DirectoryInfo(PDir);
            string Dir = PDir + (from f in inf.GetFiles() orderby f.LastWriteTime descending select f).FirstOrDefault().ToString();
            Console.WriteLine(Dir);
            return Dir;
        }
    }
}
