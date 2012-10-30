using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using RedAlertConfig;

namespace RedAlertConfig
{
    public partial class Form1 : Form
    {
        public int ResoWidth, ResoHeight;

        public Form1()
        {
            Files.Init();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           if (File.Exists("ddraw.dll") == true)
            {
                this.chb_EnableCnCDDraw.Checked = true;
            }

           if (Files.RedAlertINI.getBoolValue("Options", "UseRAAspectRatio", false) == true)
           {
               ResoWidth = Files.DDrawINI.getIntValue("ddraw", "width", 0);
               ResoHeight = Files.DDrawINI.getIntValue("ddraw", "height", 0);
           }
           else
           {
               ResoWidth = Files.RedAlertINI.getIntValue("Options", "Width", 640);
               ResoHeight = Files.RedAlertINI.getIntValue("Options", "Height", 480);
           }

           this.txtb_resoCustomHeight.Enabled = false;
           this.txtb_resoCustomWidth.Enabled = false;
           this.but_DetectReso.Enabled = false;

           this.txtb_resoCustomHeight.Text = ResoHeight.ToString();
           this.txtb_resoCustomWidth.Text = ResoWidth.ToString();

            if (ResoWidth == 640 && ResoHeight == 400)
            {
                this.radiob_reso640x400.Checked = true;
            }
            else if (ResoWidth == 640 && ResoHeight == 480)
            {
                this.radiob_reso640x480.Checked = true;
            }
            else if (ResoWidth == 800 && ResoHeight == 600)
            {
                this.radiob_reso800x600.Checked = true;
            }
            else if (ResoWidth == 1024 && ResoHeight == 768)
            {
                this.radiob_reso1024x768.Checked = true;
            }
            else
            {
                this.radiob_resoCustom.Checked = true;
            }
            Update_Use_RA_Aspect_Ratio();

            this.txtb_StretchCustomWidth.Enabled = false;
            this.txtb_StretchCustomHeight.Enabled = false;
            
            int StretchWidth = Files.DDrawINI.getIntValue("ddraw", "width", 0);
            int StretchHeight = Files.DDrawINI.getIntValue("ddraw", "height", 0);

            this.txtb_StretchCustomWidth.Text = StretchWidth.ToString();
            this.txtb_StretchCustomHeight.Text = StretchHeight.ToString();

            if (this.txtb_StretchCustomWidth.Text == "0") this.txtb_StretchCustomWidth.Text = "";
            if (this.txtb_StretchCustomHeight.Text == "0") this.txtb_StretchCustomHeight.Text = "";

            txtb_Handle.Text = Files.RedAlertINI.getStringValue("Multiplayer", "Handle", "");

            if (Files.RedAlertINI.getBoolValue("Intro", "PlayIntro", false) == true)
            {
                chb_PlayIntro.Checked = true;
            }

            if (!File.Exists("movies1.mix") && !File.Exists("movies2.mix"))
            {
                chb_PlayIntro.Enabled = false;
            }

            if (Files.RedAlertINI.getBoolValue("Options", "IsScoreRepeat", false) == true)
            {
                this.chb_RepeatMusic.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("Options", "IsScoreShuffle", false) == true)
            {
                this.chb_ShuffleMusic.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("Options", "AutoScroll", false) == true)
            {
                this.chb_Autoscroll.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("Options", "PaletteScroll", false) == true)
            {
                this.chb_PaletteScroll.Checked = true;
            }
            
            double derp;
            if (Double.TryParse(Files.RedAlertINI.getStringValue("Options", "Volume", "0"),  out derp) == false)
            {
                derp = 0;
            }
            int SoundVolume = ((int)(derp * 1000));
            this.slider_SoundVolume.Value = SoundVolume;

            double derp2;
            if (Double.TryParse(Files.RedAlertINI.getStringValue("Options", "MultiplayerScoreVolume", "0"), out derp2) == false)
            {
                derp2 = 0;
            }
            int MusicVolume = ((int)(derp2 * 1000));
            this.Slider_MusicVolume.Value = MusicVolume;

            int GameSpeed = Files.RedAlertINI.getIntValue("Options", "GameSpeed", 3);
            this.slider_GameSpeed.Value = 6 - GameSpeed;

            int ScrollRate = Files.RedAlertINI.getIntValue("Options", "ScrollRate", 3);
            this.slider_ScrollRate.Value = 6 - ScrollRate;

            this.cmbox_Side.SelectedIndex = Files.RedAlertINI.getIntValue("MultiPlayer", "Side", 2)-2;

            this.cmbox_Color.SelectedIndex = Files.RedAlertINI.getIntValue("MultiPlayer", "Color", 0);

            String ScalingFilter = Files.DDrawINI.getStringValue("ddraw", "filter", "");

            if (ScalingFilter.ToLower() == "nearest")
            {
                this.cmbox_ScalingFilter.SelectedIndex = 0;
            }
            else if (ScalingFilter.ToLower() == "linear")
            {
                this.cmbox_ScalingFilter.SelectedIndex = 1;
            }
            if (Files.RedAlertINI.getBoolValue("Options", "UseRAAspectRatio", false) == true)
            {
                this.chb_UseRAAspectRatio.Checked = true;
            }
            else if (StretchHeight != 0 && StretchWidth != 0)
            {
                this.chb_StretchCustom.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("Options", "HardwareFills", false) == true)
            {
                this.chb_AllowHardwareFilledBits.Checked = true;
            }
            if (this.chb_EnableCnCDDraw.Checked == true)
            {
                this.chb_AllowHardwareFilledBits.Enabled = false;
            }

            if (Files.RedAlertINI.getBoolValue("Options", "VideoBackBuffer", false) == true)
            {
                this.chb_BackBufferVideoMemory.Checked = true;
            }
        }

        private void Update_Use_RA_Aspect_Ratio()
        {
            this.chb_UseRAAspectRatio.Enabled = true;
            this.label18.Enabled = true;
            this.txt_UseRAAspectRatio.Enabled = true;

            int CustomResoWidth;
            if (Int32.TryParse(this.txtb_resoCustomWidth.Text, out CustomResoWidth) == false)
            {
                CustomResoWidth = 0;
            }

            int CustomResoHeight;
            if (Int32.TryParse(this.txtb_resoCustomHeight.Text, out CustomResoHeight) == false)
            {
                CustomResoHeight = 0;
            }

            if (this.radiob_reso640x400.Checked== true)
            {
                CustomResoWidth = 640;
                CustomResoHeight = 400;
            }
            else if (this.radiob_reso640x480.Checked == true)
            {
                CustomResoWidth = 640;
                CustomResoHeight = 480;
            }
            else if (this.radiob_reso800x600.Checked == true)
            {
                CustomResoWidth = 800;
                CustomResoHeight = 600;
            }
            else if (this.radiob_reso1024x768.Checked == true)
            {
                CustomResoWidth = 1024;
                CustomResoHeight = 768;
            }

            this.txt_UseRAAspectRatio.Text = String.Format("({0}x{1} stretched to {0}x{2})",
                (int)CustomResoWidth, (int)(CustomResoHeight / 1.2), (int)CustomResoHeight);

            if (this.radiob_reso640x400.Checked == true || (this.radiob_resoCustom.Checked == true
            && (CustomResoWidth < 640 || CustomResoHeight < 480)))
            //if (ResoWidth < 640 || ResoHeight < 480)
            {
                this.chb_UseRAAspectRatio.Enabled = false;
                this.chb_UseRAAspectRatio.Checked= false;

                this.label18.Enabled = false;
                this.txt_UseRAAspectRatio.Enabled = false;
                this.txt_UseRAAspectRatio.Text = "(needs to be at least 640x480)";
            }

            String Renderer = Files.DDrawINI.getStringValue("ddraw", "renderer", "opengl");

            if (Renderer.ToLower() == "gdi")
            {
                this.radiob_RendererGDI.Checked = true;
            }
            else
            {
                this.radiob_RendererOpenGL.Checked = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cncnet.org");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cncnet.exe";
            process.StartInfo.Arguments = "-CFG";
            process.StartInfo.UseShellExecute = false;
            process.Start();
        }

        private void chb_EnableSmallInfantry_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();      
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            if (this.chb_EnableCnCDDraw.Checked == true)
            {
                this.chb_AllowHardwareFilledBits.Checked = false;
                Files.RedAlertINI.setBoolValue("Options", "HardwareFills", false);
            }

            if (this.radiob_reso640x400.Checked == true)
            {
                Files.RedAlertINI.setIntValue("Options", "Width", 640);
                Files.RedAlertINI.setIntValue("Options", "Height", 400);
            }
            else if (this.radiob_reso640x480.Checked == true)
            {
                Files.RedAlertINI.setIntValue("Options", "Width", 640);
                Files.RedAlertINI.setIntValue("Options", "Height", 480);
            }
            else if (this.radiob_reso800x600.Checked == true)
            {
                Files.RedAlertINI.setIntValue("Options", "Width", 800);
                Files.RedAlertINI.setIntValue("Options", "Height", 600);
            }
            else if (this.radiob_reso1024x768.Checked == true)
            {
                Files.RedAlertINI.setIntValue("Options", "Width", 1024);
                Files.RedAlertINI.setIntValue("Options", "Height", 768);
            }
            else if (this.radiob_resoCustom.Checked == true)
            {
                int ResolutionWidth;
                if (Int32.TryParse(this.txtb_resoCustomWidth.Text, out ResolutionWidth) == false)
                {
                    ResolutionWidth = 0;
                }
                Files.RedAlertINI.setIntValue("Options", "Width", ResolutionWidth);

                int ResolutionHeight;
                if (Int32.TryParse(this.txtb_resoCustomHeight.Text, out ResolutionHeight) == false)
                {
                    ResolutionHeight = 0;
                }
                Files.RedAlertINI.setIntValue("Options", "Height", ResolutionHeight);
            }

            if (this.chb_UseRAAspectRatio.Checked == false)
            {
                Files.RedAlertINI.setBoolValue("Options", "UseRAAspectRatio", false);
            }
            if (this.chb_UseRAAspectRatio.Checked == true)
            {
                int RAHeight = Files.RedAlertINI.getIntValue("Options", "Height", 0);
                Files.DDrawINI.setIntValue("ddraw", "height", RAHeight);
                Files.RedAlertINI.setIntValue("Options", "Height", (int)(RAHeight / 1.2));

                Files.RedAlertINI.setBoolValue("Options", "UseRAAspectRatio", true);

                int RAWidth = Files.RedAlertINI.getIntValue("Options", "Width", 0);
                Files.DDrawINI.setIntValue("ddraw", "width", RAWidth);
            }
            else if (this.chb_StretchCustom.Checked == true)
            {
                int StretchWidth;
                if (Int32.TryParse(this.txtb_StretchCustomWidth.Text, out StretchWidth) == false)
                {
                    StretchWidth = 0;
                }
                Files.DDrawINI.setIntValue("ddraw", "width", StretchWidth);

                int StretchHeight;
                if (Int32.TryParse(this.txtb_StretchCustomHeight.Text, out StretchHeight) == false)
                {
                    StretchHeight = 0;
                }
                Files.DDrawINI.setIntValue("ddraw", "height", StretchHeight);
            }
            else
            {
                Files.DDrawINI.setIntValue("ddraw", "height", 0);
                Files.DDrawINI.setIntValue("ddraw", "width", 0);
            }

            Files.RedAlertINI.setStringValue("Multiplayer", "Handle", txtb_Handle.Text);

            if (chb_PlayIntro.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Intro", "PlayIntro", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Intro", "PlayIntro", false);
            }

            if (this.chb_RepeatMusic.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "IsScoreRepeat", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "IsScoreRepeat", false);
            }

            if (this.chb_ShuffleMusic.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "IsScoreShuffle", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "IsScoreShuffle", false);
            }

            if (this.chb_Autoscroll.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "AutoScroll", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "AutoScroll", false);
            }

            if (this.chb_PaletteScroll.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "PaletteScroll", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "PaletteScroll", false);
            }

            double Volume = ((double)this.slider_SoundVolume.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "Volume", Volume.ToString());

            double MusicVolume = ((double)this.Slider_MusicVolume.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "ScoreVolume", MusicVolume.ToString());
            Files.RedAlertINI.setStringValue("Options", "MultiplayerScoreVolume", MusicVolume.ToString());

            int GameSpeed = 6 - this.slider_GameSpeed.Value;
            Files.RedAlertINI.setIntValue("Options", "GameSpeed", GameSpeed);

            int ScrollRate = 6 - this.slider_ScrollRate.Value;
            Files.RedAlertINI.setIntValue("Options", "ScrollRate", ScrollRate);

            Files.RedAlertINI.setIntValue("MultiPlayer", "Side", this.cmbox_Side.SelectedIndex + 2);

            Files.RedAlertINI.setIntValue("MultiPlayer", "Color", this.cmbox_Color.SelectedIndex);

            if (this.radiob_RendererGDI.Checked == true)
            {
                Files.DDrawINI.setStringValue("ddraw", "renderer", "gdi");
            }
            else if (this.radiob_RendererOpenGL.Checked == true)
            {
                Files.DDrawINI.setStringValue("ddraw", "renderer", "opengl");
            }

            if (this.cmbox_ScalingFilter.SelectedIndex == 0)
            {
                Files.DDrawINI.setStringValue("ddraw", "filter", "nearest");
            }
            else if (this.cmbox_ScalingFilter.SelectedIndex == 1)
            {
                Files.DDrawINI.setStringValue("ddraw", "filter", "linear");
            }

            Files.RedAlertINI.writeIni();
            Files.DDrawINI.writeIni();

            Application.Exit();
        }

        private void radiob_reso640x400_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radiob_reso640x400.Checked == true)
            {
                this.radiob_reso640x480.Checked = false;
                this.radiob_reso800x600.Checked = false;
                this.radiob_reso1024x768.Checked = false;
                this.radiob_resoCustom.Checked = false;
            }
        }

        private void radiob_reso640x480_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radiob_reso640x480.Checked == true)
            {
 //               this.radiob_reso640x400.Checked = false;
 //               this.radiob_reso800x600.Checked = false;
 //               this.radiob_reso1024x768.Checked = false;
 //               this.radiob_resoCustom.Checked = false;
            }
        }

        private void radiob_reso800x600_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiob_reso1024x768_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtb_resoCustomWidth_TextChanged(object sender, EventArgs e)
        {
/*            if (this.txtb_resoCustomWidth.Text.Length == 0)
            {
                this.txtb_resoCustomWidth.Text = "0";
            } */
            Update_Use_RA_Aspect_Ratio();
        }

        private void txtb_resoCustomHeight_TextChanged(object sender, EventArgs e)
        {
/*           if (this.txtb_resoCustomHeight.Text.Length == 0)
            {
                this.txtb_resoCustomHeight.Text = "0";
            } */
            Update_Use_RA_Aspect_Ratio();
        }

        private void radiob_resoCustom_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.radiob_resoCustom.Checked == false)
            {
                this.txtb_resoCustomHeight.Enabled = false;
                this.txtb_resoCustomWidth.Enabled = false;
                this.but_DetectReso.Enabled = false;
            }
            else
            {
                this.txtb_resoCustomHeight.Enabled = true;
                this.txtb_resoCustomWidth.Enabled = true;
                this.but_DetectReso.Enabled = true;
            }
        }

        private void but_DetectReso_Click(object sender, EventArgs e)
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            this.txtb_resoCustomWidth.Text = resolution.Width.ToString();
            this.txtb_resoCustomHeight.Text = resolution.Height.ToString();
        }

        private void radiob_reso640x400_CheckedChanged_1(object sender, EventArgs e)
        {
            Update_Use_RA_Aspect_Ratio();
        }

        private void radiob_reso640x480_CheckedChanged_1(object sender, EventArgs e)
        {
            Update_Use_RA_Aspect_Ratio();
        }

        private void radiob_reso800x600_CheckedChanged_1(object sender, EventArgs e)
        {
            Update_Use_RA_Aspect_Ratio();
        }

        private void radiob_reso1024x768_CheckedChanged_1(object sender, EventArgs e)
        {
            Update_Use_RA_Aspect_Ratio();
        }

        private void chb_UseRAAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_UseRAAspectRatio.Checked == true)
            {
                this.chb_StretchCustom.Checked = false;
            }
        }

        private void chb_StretchCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_StretchCustom.Checked == true)
            {
                this.chb_UseRAAspectRatio.Checked = false;

                this.txtb_StretchCustomHeight.Enabled = true;
                this.txtb_StretchCustomWidth.Enabled = true;
            }
            else
            {
                this.txtb_StretchCustomHeight.Enabled = false;
                this.txtb_StretchCustomWidth.Enabled = false;
            }
        }

        private void chb_EnableCnCDDraw_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_EnableCnCDDraw.Checked == false)
            {
                this.chb_AllowHardwareFilledBits.Enabled = true;
            }
            else
            {
                this.chb_AllowHardwareFilledBits.Enabled = false;
            }
        }
    }
}
