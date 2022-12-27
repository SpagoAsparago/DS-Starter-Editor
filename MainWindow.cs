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


namespace DS_Starter_Editor
{
    public partial class Form1 : Form
    {
        int GameSelected; //1 Plat, 2 HGSS, 3 BW, 4 BW2
        string FolderPath;
        string[] Pokemons;
        string[] Gen4Pokemons;
        string[] Gen5Pokemons;
        string[] PokemonTypes;

        //variables for hex editing
        string Offset1 = "";
        string Offset2 = "";
        string Offset3 = "";
        string FilePath = "";
        int Offset1Int;
        int Offset2Int;
        int Offset3Int;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            SelectFolderButton.Enabled = false;
            ChangeButton.Enabled = false;

            //Load text entries from the txt files containin Pokemon names and types
            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(),"Pokemons.txt"))) 
            {
                ProgressLabel.Text = "Loading pokemon name text banks...";
                Pokemons = File.ReadAllLines("Pokemons.txt");
                Gen4Pokemons = File.ReadAllLines("Gen4Pokemons.txt");
                Gen5Pokemons = File.ReadAllLines("Gen5Pokemons.txt");
                PokemonTypes = File.ReadAllLines("PokemonTypes.txt");
                

            } else
            {
                ProgressLabel.Text = "Pokemons.txt not found";
            }
            ProgressLabel.Text = "Please select a game";
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm popup = new AboutForm();
            DialogResult dialogresult = popup.ShowDialog();

            popup.Dispose();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm popup = new HelpForm();
            DialogResult dialogResult = popup.ShowDialog();

            popup.Dispose();
        }

        private void GameSelectButton_Click(object sender, EventArgs e)
        {
            GameSelection gameSelection = new GameSelection(GameSelected);
            DialogResult dialResult = gameSelection.ShowDialog();
            GameSelected = gameSelection.Game;
            ProgressLabel.Text = GameSelected.ToString();

            if (GameSelected != 0)
            {
                SelectFolderButton.Enabled = true;
                ProgressLabel.Text = "Selected the project folder of your ROM";
            }
            
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Directory.GetCurrentDirectory();
            if (fbd.ShowDialog() == DialogResult.OK) { 
                 FolderPath = fbd.SelectedPath;
            } else
            {
                GameSelected = 0;
            }
            //Check if the selected folder contains the correct header for the selected game (US version)
            switch (GameSelected)
            {
                case 0:
                    SelectFolderButton.Enabled = false;
                    ProgressLabel.Text = "Error: No game selected";
                    SelectionLabel.Text = "Selected a new project folder";
                    break;
                case 1:
                    if (File.Exists(Path.Combine(FolderPath,"header.bin"))){

                        ProgressLabel.Text = "Reading the header information...";
                        FilePath = Path.Combine(FolderPath, "header.bin");
                        Stream stream = File.OpenRead(FilePath);
                        BinaryReader reader = new BinaryReader(stream);
                        stream.Seek(0x0, SeekOrigin.Begin);
                        //50 4F 4B 45 4D 4F 4E 20
                        if (reader.ReadInt64()== 0x204E4F4D454B4F50)
                        {
                            //50 4C 00 00 43 50 55 45
                            if (reader.ReadInt64()== 0x4555504300004C50)
                            {
                                ChangeButton.Enabled = true;
                                ProgressLabel.Text = "Game detected: POKEMON PL CPUE";
                                SelectionLabel.Text = "Project folder loaded: Pokemon Platinum US Version";
                            } else
                            {
                                ProgressLabel.Text = "Error: header file does not contain the correct bytes";
                                GameSelected = 0;
                            }
                        } else
                        {
                            ProgressLabel.Text = "Error: header file does not contain the correct bytes";
                            GameSelected = 0;
                        }

                        stream.Dispose();
                        reader.Dispose();
                    } else
                    {
                        ProgressLabel.Text = "Header file not found. Make sure the project folder you selected is correct";
                        GameSelected = 0;
                    }
                    break;
                case 2:
                    if (File.Exists(Path.Combine(FolderPath, "header.bin")))
                    {
                        ProgressLabel.Text = "Reading the header information...";
                        FilePath = Path.Combine(FolderPath, "header.bin");
                        Stream stream = File.OpenRead(FilePath);
                        BinaryReader reader = new BinaryReader(stream);
                        stream.Seek(0x0, SeekOrigin.Begin);
                        //50 4F 4B 45 4D 4F 4E 20
                        if (reader.ReadInt64() == 0x204E4F4D454B4F50)
                        {
                            Int64 temp = reader.ReadInt64();
                            //48 47 00 00 49 50 4B 45
                            if (temp == 0x454B504900004748)
                            {
                                ChangeButton.Enabled = true;
                                ProgressLabel.Text = "Game detected: POKEMON HG IPKE";
                                SelectionLabel.Text = "Project folder loaded: Pokemon HeartGold US Version";
                            }
                            //53 53 00 00 49 50 47 45
                            else if (temp == 0x4547504900005353)
                            {
                                ChangeButton.Enabled = true;
                                ProgressLabel.Text = "Game detected: POKEMON SS IPGE";
                                SelectionLabel.Text = "Project folder loaded: Pokemon SoulSilver US Version";
                            }
                            else
                            {
                                ProgressLabel.Text = "Error: header file does not contain the correct bytes";
                                GameSelected = 0;
                            }
                        }
                        else
                        {
                            ProgressLabel.Text = "Error: header file does not contain the correct bytes";
                            GameSelected = 0;
                        }

                        stream.Dispose();
                        reader.Dispose();
                    }
                    else
                    {
                        ProgressLabel.Text = "Error: header file not found. Make sure the folder you selected is correct";
                        GameSelected = 0;
                    }
                    break;
                case 3:
                    if (File.Exists(Path.Combine(FolderPath, "header.bin")))
                    {
                        ProgressLabel.Text = "Game detected:";
                        ChangeButton.Enabled = true;
                    }
                    else
                    {
                        ProgressLabel.Text = "Error: header file not found. Make sure the folder you selected is correct";
                    }
                    break;
                case 4:
                    if (File.Exists(Path.Combine(FolderPath, "header.bin")))
                    {
                        ProgressLabel.Text = "Game detected:";
                        ChangeButton.Enabled = true;
                    }
                    else
                    {
                        ProgressLabel.Text = "Error: header file not found. Make sure the folder you selected is correct";
                    }
                    break;
                default:
                    break;

                
            }
            //Load the starter names in the Labels by reading the bytes
            if (GameSelected != 0) { 
                LoadStarters(GameSelected);
            }
        }

       private void LoadStarters(int Game)
        {
          ProgressLabel.Text = "Loading starters...";
          //Check the selected game and load the comboboxes with the appropriate generation text files, set each slot offset and the arm9/ovl path
          switch (Game)
            {
                case 1:
                    comboBox1.Items.AddRange(Gen4Pokemons);
                    comboBox2.Items.AddRange(Gen4Pokemons);
                    comboBox3.Items.AddRange(Gen4Pokemons);
                    FilePath = Path.Combine(FolderPath + "\\overlay", "overlay_0078.bin");
                    //Pt Starter offsets in ovl78
                    Offset1 = "1BC0";
                    Offset2 = "1BC4";
                    Offset3 = "1BC8";

                    break;
                case 2:
                    comboBox1.Items.AddRange(Gen4Pokemons);
                    comboBox2.Items.AddRange(Gen4Pokemons);
                    comboBox3.Items.AddRange(Gen4Pokemons);
                    FilePath = Path.Combine(FolderPath, "arm9.bin");
                    //HGSS Starter offsets in the arm9
                    Offset1 = "108514";
                    Offset2 = "108518";
                    Offset3 = "10851C";

                    break;
                case 3:
                    comboBox1.Items.AddRange(Gen5Pokemons);
                    comboBox2.Items.AddRange(Gen5Pokemons);
                    comboBox3.Items.AddRange(Gen5Pokemons);
                    //???

                    break;
                case 4:
                    comboBox1.Items.AddRange(Gen5Pokemons);
                    comboBox2.Items.AddRange(Gen5Pokemons);
                    comboBox3.Items.AddRange(Gen5Pokemons);
                    //Ovl66?

                    break;
            }

            Offset1Int = Convert.ToInt32(Offset1, 16);
            Offset2Int = Convert.ToInt32(Offset2, 16);
            Offset3Int = Convert.ToInt32(Offset3, 16);

           //Read every starter offset and set the corresponding Label to their name 
           if (File.Exists(FilePath)) 
            { 
                Stream stream = File.OpenRead(FilePath);
                BinaryReader reader = new BinaryReader(stream);

                stream.Seek(Offset1Int, SeekOrigin.Begin);
                int Slot1 = reader.ReadInt32() - 1;
                Slot1Label.Text = Pokemons[Slot1];
                comboBox1.SelectedIndex = Slot1;


                stream.Seek(Offset2Int, SeekOrigin.Begin);
                int Slot2 = reader.ReadInt32() - 1;
                Slot2Label.Text = Pokemons[Slot2];
                comboBox2.SelectedIndex = Slot2;


                stream.Seek(Offset3Int, SeekOrigin.Begin);
                int Slot3 = reader.ReadInt32() - 1;
                Slot3Label.Text = Pokemons[Slot3];
                comboBox3.SelectedIndex = Slot3;

                stream.Dispose();
                reader.Dispose();
            }
            ProgressLabel.Text = "Starters loaded";
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
          int CriesOffset;
          ProgressLabel.Text = "Creating new filestream and binaryWriter...";
          switch (GameSelected)
            {
                //Platinum Starters
                case 1:
                    //Change starters in ovl78
                    ProgressLabel.Text = "Changing starters...";
                    FilePath = Path.Combine(FolderPath + "\\overlay", "overlay_0078.bin");
                    if (File.Exists(FilePath))
                    {
                        //Change starter slots (and cries)
                        Stream stream = File.OpenWrite(FilePath);
                        BinaryWriter writer = new BinaryWriter(stream);

                        stream.Seek(Offset1Int, SeekOrigin.Begin);
                        string hexvalue = Convert.ToString(comboBox1.SelectedIndex + 1, 16);
                        writer.Write(Convert.ToInt32(hexvalue, 16));

                        stream.Seek(Offset2Int, SeekOrigin.Begin);
                        hexvalue = Convert.ToString(comboBox2.SelectedIndex + 1, 16);
                        writer.Write(Convert.ToInt32(hexvalue, 16));

                        stream.Seek(Offset3Int, SeekOrigin.Begin);
                        hexvalue = Convert.ToString(comboBox3.SelectedIndex + 1, 16);
                        writer.Write(Convert.ToInt32(hexvalue, 16));



                        //Change starter sprites in the briefcase
                        ProgressLabel.Text = "Changing starter sprites...";
                        stream.Seek(0x690, SeekOrigin.Begin);
                        hexvalue = "";
                        string substring1="";
                        string substring2="";
                        //0 < ID < 256, first slot
                        if (((comboBox1.SelectedIndex+1) > 0) && ((comboBox1.SelectedIndex+1) < 256))
                        {
                            hexvalue = "22" + Convert.ToString(comboBox1.SelectedIndex+1,16);
                            //81 20 80 00
                            substring1 = "00802081";
                            //28 18 29 1C
                            substring2 = "1C291828";
                        } 
                        //260 < ID < 517, first slot
                        else if (((comboBox1.SelectedIndex + 1) > 260) && ((comboBox1.SelectedIndex + 1) < 517)) 
                        {
                            hexvalue = "3A" + Convert.ToString(516 - (comboBox1.SelectedIndex+1),16);
                            //81 22 92 00
                            substring1 = "00922281";
                            //A8 18 29 1C
                            substring2 = "1C2918A8";
                        }

                        if (hexvalue != "")
                        {
                            writer.Write(Convert.ToInt32(substring1, 16));
                            writer.Write(Convert.ToInt32(substring2, 16));
                            writer.Write(Convert.ToInt16(hexvalue, 16));
                        }
                        hexvalue = "";

                        
                        stream.Seek(0x69E, SeekOrigin.Begin);
                        //0 < ID < 255, second slot
                        if (((comboBox2.SelectedIndex + 1) > 0) && ((comboBox2.SelectedIndex + 1) < 256))
                        {
                            hexvalue = "22" + Convert.ToString(comboBox2.SelectedIndex + 1, 16);
                            //82 20 80 00
                            substring1 = "00802082";
                            //28 18 29 1C
                            substring2 = "1C291828";
                        } 
                        //264 < ID < 521, second slot
                        else if (((comboBox2.SelectedIndex + 1) > 264) && ((comboBox2.SelectedIndex + 1) < 521))
                        {
                            hexvalue = "3A" + Convert.ToString(520 - (comboBox2.SelectedIndex + 1), 16);
                            //82 22 92 00
                            substring1 = "00922282";
                            //A8 18 29 1C
                            substring2 = "1C2918A8";
                        }
                        if (hexvalue != "")
                        {
                            writer.Write(Convert.ToInt32(substring1, 16));
                            writer.Write(Convert.ToInt32(substring2, 16));
                            writer.Write(Convert.ToInt16(hexvalue, 16));
                        }
                        hexvalue = "";

                        stream.Seek(0x6AC, SeekOrigin.Begin);
                        //0 < ID < 255, third slot
                        if (((comboBox3.SelectedIndex + 1) > 0) && ((comboBox3.SelectedIndex + 1) < 256))
                        {
                            hexvalue = "22" + Convert.ToString(comboBox3.SelectedIndex + 1, 16);
                            //83 20 80 00
                            substring1 = "00802083";
                            //28 18 29 1C
                            substring2 = "1C291828";

                        }
                        //268 < ID < 525, third slot
                        else if (((comboBox3.SelectedIndex + 1) > 268) && ((comboBox3.SelectedIndex + 1) < 525))
                        {
                            hexvalue = "3A" + Convert.ToString(524 - (comboBox3.SelectedIndex + 1), 16);
                            //83 22 92 00
                            substring1 = "00922283";
                            //A8 18 29 1C
                            substring2 = "1C2918A8";
                        }

                        if (hexvalue != "")
                        {
                            writer.Write(Convert.ToInt32(substring1, 16));
                            writer.Write(Convert.ToInt32(substring2, 16));
                            writer.Write(Convert.ToInt16(hexvalue, 16));
                        }
                        
                        stream.Dispose();
                        writer.Dispose();

                    }
                    break;

                //HGSS Starters
                case 2:

                    //Change the actual starters in the arm9
                    ProgressLabel.Text = "Changing starters...";
                    FilePath = Path.Combine(FolderPath, "arm9.bin");
                    if (File.Exists(FilePath))
                    {
                    
                        Stream stream = File.OpenWrite(FilePath);
                        BinaryWriter writer = new BinaryWriter(stream);

                        stream.Seek(Offset1Int, SeekOrigin.Begin);
                        string hexvalue = Convert.ToString(comboBox1.SelectedIndex + 1, 16);
                        writer.Write(Convert.ToInt32(hexvalue, 16));

                        stream.Seek(Offset2Int, SeekOrigin.Begin);
                        hexvalue = Convert.ToString(comboBox2.SelectedIndex + 1, 16);
                        writer.Write(Convert.ToInt32(hexvalue, 16));

                        stream.Seek(Offset3Int, SeekOrigin.Begin);
                        hexvalue = Convert.ToString(comboBox3.SelectedIndex + 1, 16);
                        writer.Write(Convert.ToInt32(hexvalue, 16));

                        stream.Dispose();
                        writer.Dispose();

                    }

                    //HGSS Starter cries: Ovl 61 0x1A98
                    //Decompress Overlay, hex edit, compress again
                    ProgressLabel.Text = "Changing starter cries...";
                    FilePath = Path.Combine(FolderPath + "\\overlay", "overlay_0061.bin");
                    if (File.Exists(FilePath))
                    {
                        DecompOvl(FilePath);

                        CriesOffset = Convert.ToInt32("1A98", 16);

                        Stream stream = File.OpenWrite(FilePath);
                        BinaryWriter writer = new BinaryWriter(stream);

                        stream.Seek(CriesOffset, SeekOrigin.Begin);
                        string hexvalue = Convert.ToString(comboBox1.SelectedIndex + 1, 16);
                        writer.Write(Convert.ToInt32(hexvalue, 16));

                        stream.Seek(CriesOffset + 4, SeekOrigin.Begin);
                        hexvalue = Convert.ToString(comboBox2.SelectedIndex + 1, 16);
                        writer.Write(Convert.ToInt32(hexvalue, 16));

                        stream.Seek(CriesOffset + 8, SeekOrigin.Begin);
                        hexvalue = Convert.ToString(comboBox3.SelectedIndex + 1, 16);
                        writer.Write(Convert.ToInt32(hexvalue, 16));

                        stream.Dispose();
                        writer.Dispose();

                        CompOvl(FilePath);
                    }
                    break;

                //BW1 Starters
                case 3:
                    break;

                //BW2 Starters
                case 4:
                    break;

                default:
                    ProgressLabel.Text = "No game has been selected";
                    break;
            }

            

            ProgressLabel.Text = "Changes applied! You can now save the ROM in DSPRE. Remember to load the already extracted data";
        }

        private void DecompOvl(string Path)
        {
            Process process = new Process();
            process.StartInfo.FileName = @"blz.exe";
            process.StartInfo.Arguments = " -d " + '"' + Path + '"'; 
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();
        }

        private void CompOvl(string Path)
        {
            Process process = new Process();
            process.StartInfo.FileName = @"blz.exe";
            process.StartInfo.Arguments = " -en " + '"' + Path + '"';
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit();
        }

        public string ConvertEndian(string HexValue)
        {
            string result = "";
            char C;

            switch (HexValue.Length)
            {
                case 1:
                    result = "0" + HexValue + "00";
                    break;

                case 2:
                    result = HexValue + "00";
                    break;

                case 3:
                    result += HexValue[1];
                    result += HexValue[2];
                    result += "0";
                    result += HexValue[0];
                    break;

                default:
                    for (int i = HexValue.Length; i > 0; i -= 2)
                    {
                        C = HexValue[i - 2];
                        result += C;
                        C = HexValue[i - 1];
                        result += C;
                    }
                    break;

            }

            return result;
        }

    }
}
