namespace SimpleDemoWin
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveButton = new System.Windows.Forms.ToolStripButton();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.ClientsListBox = new System.Windows.Forms.ListBox();
            this.ContentView = new System.Windows.Forms.Panel();
            this.Card = new ClientCard.ClientView();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.SearchByNameTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.AlphabetComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ContentView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.ClientsListBox);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 317);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.RemoveButton,
            this.EditButton,
            this.toolStripLabel1,
            this.SearchByNameTextBox,
            this.AlphabetComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // AddButton
            // 
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(63, 35);
            this.AddButton.Text = "Добавить";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(55, 35);
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // EditButton
            // 
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(91, 35);
            this.EditButton.Text = "Редактировать";
            this.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ClientsListBox
            // 
            this.ClientsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsListBox.FormattingEnabled = true;
            this.ClientsListBox.Location = new System.Drawing.Point(0, 0);
            this.ClientsListBox.Name = "ClientsListBox";
            this.ClientsListBox.Size = new System.Drawing.Size(218, 317);
            this.ClientsListBox.TabIndex = 0;
            this.ClientsListBox.SelectedIndexChanged += new System.EventHandler(this.ClientsListBox_SelectedIndexChanged);
            // 
            // ContentView
            // 
            this.ContentView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentView.Controls.Add(this.Card);
            this.ContentView.Location = new System.Drawing.Point(215, 41);
            this.ContentView.Name = "ContentView";
            this.ContentView.Size = new System.Drawing.Size(585, 314);
            this.ContentView.TabIndex = 2;
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.Location = new System.Drawing.Point(0, 0);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(585, 314);
            this.Card.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(166, 35);
            this.toolStripLabel1.Text = "Поиск по названию клиента:";
            // 
            // SearchByNameTextBox
            // 
            this.SearchByNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchByNameTextBox.Name = "SearchByNameTextBox";
            this.SearchByNameTextBox.Size = new System.Drawing.Size(100, 38);
            this.SearchByNameTextBox.TextChanged += new System.EventHandler(this.SearchByNameTextBox_TextChanged);
            // 
            // AlphabetComboBox
            // 
            this.AlphabetComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.AlphabetComboBox.Items.AddRange(new object[] {
            "А",
            "Б",
            "В",
            "Г",
            "Д",
            "Е",
            "Ё",
            "Ж",
            "З",
            "И",
            "Й",
            "К",
            "Л",
            "М",
            "Н",
            "О",
            "П",
            "Р",
            "С",
            "Т",
            "У",
            "Ф",
            "Х",
            "Ц",
            "Ч",
            "Ш",
            "Щ",
            "Э",
            "Ю",
            "Я"});
            this.AlphabetComboBox.Name = "AlphabetComboBox";
            this.AlphabetComboBox.Size = new System.Drawing.Size(121, 38);
            this.AlphabetComboBox.SelectedIndexChanged += new System.EventHandler(this.AlphabetComboBox_SelectedIndexChanged);
            this.AlphabetComboBox.TextChanged += new System.EventHandler(this.AlphabetComboBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.ContentView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ООО \"Цемент-Строй\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ContentView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton RemoveButton;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ListBox ClientsListBox;
        private System.Windows.Forms.Panel ContentView;
        private ClientCard.ClientView Card;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox SearchByNameTextBox;
        private System.Windows.Forms.ToolStripComboBox AlphabetComboBox;
    }
}

