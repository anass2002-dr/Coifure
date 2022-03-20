
namespace Coiffure
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_Configuration = new System.Windows.Forms.Button();
            this.btn_aide = new System.Windows.Forms.Button();
            this.btn_propos = new System.Windows.Forms.Button();
            this.btn_inscrir = new System.Windows.Forms.Button();
            this.btn_conecter = new System.Windows.Forms.Button();
            this.btn_reservation = new System.Windows.Forms.Button();
            this.panel_salon = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_accueil = new System.Windows.Forms.Panel();
            this.btn_minimiz = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_substract = new System.Windows.Forms.Button();
            this.lb_home = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_salon.SuspendLayout();
            this.panel_accueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panel_menu.Controls.Add(this.btn_Configuration);
            this.panel_menu.Controls.Add(this.btn_aide);
            this.panel_menu.Controls.Add(this.btn_propos);
            this.panel_menu.Controls.Add(this.btn_inscrir);
            this.panel_menu.Controls.Add(this.btn_conecter);
            this.panel_menu.Controls.Add(this.btn_reservation);
            this.panel_menu.Controls.Add(this.panel_salon);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(176, 490);
            this.panel_menu.TabIndex = 0;
            // 
            // btn_Configuration
            // 
            this.btn_Configuration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Configuration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_Configuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Configuration.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Configuration.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Configuration.Image = global::Coiffure.Properties.Resources.tune_24px;
            this.btn_Configuration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Configuration.Location = new System.Drawing.Point(0, 301);
            this.btn_Configuration.Name = "btn_Configuration";
            this.btn_Configuration.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_Configuration.Size = new System.Drawing.Size(176, 48);
            this.btn_Configuration.TabIndex = 6;
            this.btn_Configuration.Text = "Configuration";
            this.btn_Configuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Configuration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Configuration.UseVisualStyleBackColor = true;
            this.btn_Configuration.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_Configuration.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter);
            this.btn_Configuration.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave);
            // 
            // btn_aide
            // 
            this.btn_aide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_aide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_aide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aide.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aide.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_aide.Image = global::Coiffure.Properties.Resources.help_24px;
            this.btn_aide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aide.Location = new System.Drawing.Point(0, 253);
            this.btn_aide.Name = "btn_aide";
            this.btn_aide.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_aide.Size = new System.Drawing.Size(176, 48);
            this.btn_aide.TabIndex = 5;
            this.btn_aide.Text = "Aide";
            this.btn_aide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aide.UseVisualStyleBackColor = true;
            this.btn_aide.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_aide.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter);
            this.btn_aide.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave);
            // 
            // btn_propos
            // 
            this.btn_propos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_propos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_propos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_propos.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_propos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_propos.Image = global::Coiffure.Properties.Resources.about_24px;
            this.btn_propos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_propos.Location = new System.Drawing.Point(0, 205);
            this.btn_propos.Name = "btn_propos";
            this.btn_propos.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_propos.Size = new System.Drawing.Size(176, 48);
            this.btn_propos.TabIndex = 4;
            this.btn_propos.Text = "à propos";
            this.btn_propos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_propos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_propos.UseVisualStyleBackColor = true;
            this.btn_propos.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_propos.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter);
            this.btn_propos.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave);
            // 
            // btn_inscrir
            // 
            this.btn_inscrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_inscrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_inscrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inscrir.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscrir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_inscrir.Image = global::Coiffure.Properties.Resources.plus___24px;
            this.btn_inscrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inscrir.Location = new System.Drawing.Point(0, 157);
            this.btn_inscrir.Name = "btn_inscrir";
            this.btn_inscrir.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_inscrir.Size = new System.Drawing.Size(176, 48);
            this.btn_inscrir.TabIndex = 3;
            this.btn_inscrir.Text = "S\'inscrire";
            this.btn_inscrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inscrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inscrir.UseVisualStyleBackColor = true;
            this.btn_inscrir.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_inscrir.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter);
            this.btn_inscrir.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave);
            // 
            // btn_conecter
            // 
            this.btn_conecter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_conecter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_conecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conecter.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conecter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_conecter.Image = global::Coiffure.Properties.Resources.account_24px;
            this.btn_conecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_conecter.Location = new System.Drawing.Point(0, 109);
            this.btn_conecter.Name = "btn_conecter";
            this.btn_conecter.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_conecter.Size = new System.Drawing.Size(176, 48);
            this.btn_conecter.TabIndex = 2;
            this.btn_conecter.Text = "Se Connecter";
            this.btn_conecter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_conecter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_conecter.UseVisualStyleBackColor = true;
            this.btn_conecter.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_conecter.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter);
            this.btn_conecter.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave);
            // 
            // btn_reservation
            // 
            this.btn_reservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reservation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reservation.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_reservation.Image = global::Coiffure.Properties.Resources.reserve_24px;
            this.btn_reservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reservation.Location = new System.Drawing.Point(0, 61);
            this.btn_reservation.Name = "btn_reservation";
            this.btn_reservation.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_reservation.Size = new System.Drawing.Size(176, 48);
            this.btn_reservation.TabIndex = 1;
            this.btn_reservation.Text = "Réservation";
            this.btn_reservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reservation.UseVisualStyleBackColor = true;
            this.btn_reservation.Click += new System.EventHandler(this.btn_reservation_Click);
            this.btn_reservation.MouseEnter += new System.EventHandler(this.btn_reservation_MouseEnter);
            this.btn_reservation.MouseLeave += new System.EventHandler(this.btn_reservation_MouseLeave);
            // 
            // panel_salon
            // 
            this.panel_salon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.panel_salon.Controls.Add(this.label2);
            this.panel_salon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_salon.Location = new System.Drawing.Point(0, 0);
            this.panel_salon.Name = "panel_salon";
            this.panel_salon.Size = new System.Drawing.Size(176, 61);
            this.panel_salon.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Image = global::Coiffure.Properties.Resources.barbershop_24px;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salon de Coiffure";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_accueil
            // 
            this.panel_accueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel_accueil.Controls.Add(this.btn_minimiz);
            this.panel_accueil.Controls.Add(this.btn_close);
            this.panel_accueil.Controls.Add(this.btn_substract);
            this.panel_accueil.Controls.Add(this.lb_home);
            this.panel_accueil.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_accueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_accueil.Location = new System.Drawing.Point(176, 0);
            this.panel_accueil.Name = "panel_accueil";
            this.panel_accueil.Size = new System.Drawing.Size(716, 61);
            this.panel_accueil.TabIndex = 1;
            // 
            // btn_minimiz
            // 
            this.btn_minimiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimiz.FlatAppearance.BorderSize = 0;
            this.btn_minimiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimiz.Image = global::Coiffure.Properties.Resources.minimize_window_24px_white;
            this.btn_minimiz.Location = new System.Drawing.Point(653, 3);
            this.btn_minimiz.Name = "btn_minimiz";
            this.btn_minimiz.Size = new System.Drawing.Size(30, 23);
            this.btn_minimiz.TabIndex = 3;
            this.btn_minimiz.UseVisualStyleBackColor = true;
            this.btn_minimiz.Click += new System.EventHandler(this.btn_minimiz_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::Coiffure.Properties.Resources.close_window_24px;
            this.btn_close.Location = new System.Drawing.Point(685, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_substract
            // 
            this.btn_substract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_substract.FlatAppearance.BorderSize = 0;
            this.btn_substract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_substract.Image = global::Coiffure.Properties.Resources.subtract_24px_white;
            this.btn_substract.Location = new System.Drawing.Point(621, 3);
            this.btn_substract.Name = "btn_substract";
            this.btn_substract.Size = new System.Drawing.Size(30, 21);
            this.btn_substract.TabIndex = 1;
            this.btn_substract.UseVisualStyleBackColor = true;
            this.btn_substract.Click += new System.EventHandler(this.btn_substract_Click);
            // 
            // lb_home
            // 
            this.lb_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_home.AutoSize = true;
            this.lb_home.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_home.ForeColor = System.Drawing.Color.White;
            this.lb_home.Location = new System.Drawing.Point(300, 18);
            this.lb_home.Name = "lb_home";
            this.lb_home.Size = new System.Drawing.Size(75, 23);
            this.lb_home.TabIndex = 0;
            this.lb_home.Text = "Acceuil";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Coiffure.Properties.Resources.pexels_nick_demou_1319458;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(176, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 429);
            this.panel1.TabIndex = 2;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_accueil);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_salon.ResumeLayout(false);
            this.panel_accueil.ResumeLayout(false);
            this.panel_accueil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_aide;
        private System.Windows.Forms.Button btn_propos;
        private System.Windows.Forms.Button btn_inscrir;
        private System.Windows.Forms.Button btn_conecter;
        private System.Windows.Forms.Button btn_reservation;
        private System.Windows.Forms.Panel panel_salon;
        private System.Windows.Forms.Panel panel_accueil;
        private System.Windows.Forms.Label lb_home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Configuration;
        private System.Windows.Forms.Button btn_minimiz;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_substract;
    }
}

