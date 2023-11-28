namespace TravauxPratiques4
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            menuStrip1 = new MenuStrip();
            listeToolStripMenuItem = new ToolStripMenuItem();
            deplacementsDesDonnéesToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            parametresToolStripMenuItem = new ToolStripMenuItem();
            affBarOutil = new ToolStripMenuItem();
            desactBarOutil = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            imgBureau = new ToolStripMenuItem();
            colBureau = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            aProposDeTP4ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Contxt1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripMenuItem8 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { listeToolStripMenuItem, parametresToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deplacementsDesDonnéesToolStripMenuItem, quitterToolStripMenuItem });
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(48, 20);
            listeToolStripMenuItem.Text = "Listes";
            // 
            // deplacementsDesDonnéesToolStripMenuItem
            // 
            deplacementsDesDonnéesToolStripMenuItem.Name = "deplacementsDesDonnéesToolStripMenuItem";
            deplacementsDesDonnéesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            deplacementsDesDonnéesToolStripMenuItem.Size = new Size(255, 22);
            deplacementsDesDonnéesToolStripMenuItem.Text = "Deplacement des données";
            deplacementsDesDonnéesToolStripMenuItem.Click += deplacementsDesDonnéesToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            quitterToolStripMenuItem.Size = new Size(255, 22);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += toolStripButton1_Click;
            // 
            // parametresToolStripMenuItem
            // 
            parametresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { affBarOutil, desactBarOutil, toolStripSeparator1, imgBureau, colBureau });
            parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            parametresToolStripMenuItem.Size = new Size(78, 20);
            parametresToolStripMenuItem.Text = "Parametres";
            // 
            // affBarOutil
            // 
            affBarOutil.CheckOnClick = true;
            affBarOutil.Name = "affBarOutil";
            affBarOutil.Size = new Size(232, 22);
            affBarOutil.Text = "Afficher barre d'outils";
            affBarOutil.Click += toolStripMenuItem2_Click;
            // 
            // desactBarOutil
            // 
            desactBarOutil.CheckOnClick = true;
            desactBarOutil.Name = "desactBarOutil";
            desactBarOutil.Size = new Size(232, 22);
            desactBarOutil.Text = "Désactiver barre d'outils";
            desactBarOutil.Click += toolStripMenuItem3_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(229, 6);
            // 
            // imgBureau
            // 
            imgBureau.Name = "imgBureau";
            imgBureau.Size = new Size(232, 22);
            imgBureau.Text = "Afficher image pour le bureau";
            // 
            // colBureau
            // 
            colBureau.Name = "colBureau";
            colBureau.Size = new Size(232, 22);
            colBureau.Text = "Changer couleur du bureau";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aideToolStripMenuItem, aProposDeTP4ToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(24, 20);
            toolStripMenuItem1.Text = "?";
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.ShortcutKeys = Keys.F2;
            aideToolStripMenuItem.Size = new Size(202, 22);
            aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposDeTP4ToolStripMenuItem
            // 
            aProposDeTP4ToolStripMenuItem.Name = "aProposDeTP4ToolStripMenuItem";
            aProposDeTP4ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            aProposDeTP4ToolStripMenuItem.Size = new Size(202, 22);
            aProposDeTP4ToolStripMenuItem.Text = "A propos de TP4";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripSeparator2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { Contxt1, toolStripSeparator3, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripSeparator4, toolStripMenuItem6, toolStripMenuItem7, toolStripSeparator5, toolStripMenuItem8 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(233, 220);
            // 
            // Contxt1
            // 
            Contxt1.Name = "Contxt1";
            Contxt1.Size = new Size(232, 22);
            Contxt1.Text = "Déplacement de données";
            Contxt1.Click += deplacementsDesDonnéesToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(229, 6);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.CheckOnClick = true;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(232, 22);
            toolStripMenuItem2.Text = "Afficher barre d'outils";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.CheckOnClick = true;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(232, 22);
            toolStripMenuItem3.Text = "Desactiver barre d'outils";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.CheckOnClick = true;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(232, 22);
            toolStripMenuItem4.Text = "Afficher image pour le bureau";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(232, 22);
            toolStripMenuItem5.Text = "Changer couleur du Bureau";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(229, 6);
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(232, 22);
            toolStripMenuItem6.Text = "Aide";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(232, 22);
            toolStripMenuItem7.Text = "A propos de TP4";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(229, 6);
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(232, 22);
            toolStripMenuItem8.Text = "Quitter";
            toolStripMenuItem8.Click += toolStripButton1_Click;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 440);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Accueil";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem parametresToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem deplacementsDesDonnéesToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem affBarOutil;
        private ToolStripMenuItem desactBarOutil;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem imgBureau;
        private ToolStripMenuItem colBureau;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem aProposDeTP4ToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem Contxt1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem toolStripMenuItem8;
    }
}
