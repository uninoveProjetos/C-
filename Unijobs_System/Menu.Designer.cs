namespace Unijobs
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.gpbBotoes = new System.Windows.Forms.GroupBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.babaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domesticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbBotoes
            // 
            this.gpbBotoes.BackColor = System.Drawing.Color.Transparent;
            this.gpbBotoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gpbBotoes.Controls.Add(this.btnExibir);
            this.gpbBotoes.Controls.Add(this.btnSalvar);
            this.gpbBotoes.Controls.Add(this.btnExcluir);
            this.gpbBotoes.Controls.Add(this.btnAlterar);
            this.gpbBotoes.Location = new System.Drawing.Point(193, 345);
            this.gpbBotoes.Margin = new System.Windows.Forms.Padding(0);
            this.gpbBotoes.Name = "gpbBotoes";
            this.gpbBotoes.Size = new System.Drawing.Size(702, 149);
            this.gpbBotoes.TabIndex = 17;
            this.gpbBotoes.TabStop = false;
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.Transparent;
            this.btnExibir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExibir.BackgroundImage")));
            this.btnExibir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExibir.Location = new System.Drawing.Point(51, 10);
            this.btnExibir.Margin = new System.Windows.Forms.Padding(0);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(113, 72);
            this.btnExibir.TabIndex = 4;
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(581, 10);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 72);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(225, 10);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 72);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.Location = new System.Drawing.Point(403, 10);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(113, 72);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.BackgroundColor = System.Drawing.Color.Black;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(12, 48);
            this.dgDados.Name = "dgDados";
            this.dgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDados.Size = new System.Drawing.Size(1054, 294);
            this.dgDados.TabIndex = 15;
            this.dgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDados_CellContentClick);
            this.dgDados.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDados_CellMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.babaToolStripMenuItem,
            this.domesticaToolStripMenuItem,
            this.outrosToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // babaToolStripMenuItem
            // 
            this.babaToolStripMenuItem.Name = "babaToolStripMenuItem";
            this.babaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.babaToolStripMenuItem.Text = "Baba";
            this.babaToolStripMenuItem.Click += new System.EventHandler(this.babaToolStripMenuItem_Click);
            // 
            // domesticaToolStripMenuItem
            // 
            this.domesticaToolStripMenuItem.Name = "domesticaToolStripMenuItem";
            this.domesticaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.domesticaToolStripMenuItem.Text = "Domestica";
            this.domesticaToolStripMenuItem.Click += new System.EventHandler(this.domesticaToolStripMenuItem_Click);
            // 
            // outrosToolStripMenuItem
            // 
            this.outrosToolStripMenuItem.Name = "outrosToolStripMenuItem";
            this.outrosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.outrosToolStripMenuItem.Text = "Outros";
            this.outrosToolStripMenuItem.Click += new System.EventHandler(this.outrosToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.gpbBotoes);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.gpbBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBotoes;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgDados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem babaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domesticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem;
    }
}