﻿using System;
using System.Drawing;
using System.Windows.Forms;
using TagsCloudContainer.UiActions;

namespace TagsCloudContainer
{
    public class MainForm : Form
    {
        public MainForm(IUiAction[] actions, PictureBoxImageHolder pictureBox, ImageSettings settings)
        {
            ClientSize = new Size(settings.Width, settings.Height);
            var mainMenu = new MenuStrip();
            mainMenu.Items.AddRange(actions.ToMenuItems());
            Controls.Add(mainMenu);

            pictureBox.RecreateImage(settings);
            pictureBox.Dock = DockStyle.Fill;
            Controls.Add(pictureBox);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Text = "Tag Cloud Visualization";
        }
    }
}