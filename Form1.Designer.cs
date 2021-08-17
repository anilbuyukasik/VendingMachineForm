
namespace VendingMachineForm
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.productPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampaignedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightTopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.moneyPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnTL5 = new System.Windows.Forms.Button();
            this.btnTL10 = new System.Windows.Forms.Button();
            this.btnTL20 = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnTL1 = new System.Windows.Forms.Button();
            this.billPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.rightTopPanel.SuspendLayout();
            this.moneyPanel.SuspendLayout();
            this.billPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Controls.Add(this.productPanel, 0, 0);
            this.mainPanel.Controls.Add(this.cartGridView, 0, 1);
            this.mainPanel.Controls.Add(this.rightTopPanel, 1, 0);
            this.mainPanel.Controls.Add(this.pictureBox1, 1, 1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainPanel.Size = new System.Drawing.Size(1091, 764);
            this.mainPanel.TabIndex = 0;
            // 
            // productPanel
            // 
            this.productPanel.ColumnCount = 3;
            this.productPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.5F));
            this.productPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.5F));
            this.productPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.productPanel.Controls.Add(this.btn12, 2, 3);
            this.productPanel.Controls.Add(this.btn11, 1, 3);
            this.productPanel.Controls.Add(this.btn10, 0, 3);
            this.productPanel.Controls.Add(this.btn9, 2, 2);
            this.productPanel.Controls.Add(this.btn8, 1, 2);
            this.productPanel.Controls.Add(this.btn7, 0, 2);
            this.productPanel.Controls.Add(this.btn6, 2, 1);
            this.productPanel.Controls.Add(this.btn5, 1, 1);
            this.productPanel.Controls.Add(this.btn4, 0, 1);
            this.productPanel.Controls.Add(this.btn3, 2, 0);
            this.productPanel.Controls.Add(this.btn2, 1, 0);
            this.productPanel.Controls.Add(this.btn1, 0, 0);
            this.productPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPanel.Location = new System.Drawing.Point(3, 3);
            this.productPanel.Name = "productPanel";
            this.productPanel.RowCount = 4;
            this.productPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.productPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.productPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.productPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.productPanel.Size = new System.Drawing.Size(539, 376);
            this.productPanel.TabIndex = 0;
            // 
            // btn12
            // 
            this.btn12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn12.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn12.Location = new System.Drawing.Point(363, 285);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(173, 88);
            this.btn12.TabIndex = 11;
            this.btn12.Text = "button12";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btn11
            // 
            this.btn11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn11.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn11.Location = new System.Drawing.Point(183, 285);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(174, 88);
            this.btn11.TabIndex = 10;
            this.btn11.Text = "button11";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btn10
            // 
            this.btn10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn10.Location = new System.Drawing.Point(3, 285);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(174, 88);
            this.btn10.TabIndex = 9;
            this.btn10.Text = "button10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(363, 191);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(173, 88);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "button9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(183, 191);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(174, 88);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "button8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(3, 191);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(174, 88);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "button7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(363, 97);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(173, 88);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "button6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(183, 97);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(174, 88);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "button5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(3, 97);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(174, 88);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "button4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(363, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(173, 88);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(183, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(174, 88);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(174, 88);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.ButtonsClick);
            // 
            // cartGridView
            // 
            this.cartGridView.AllowUserToOrderColumns = true;
            this.cartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProductName,
            this.Price,
            this.CampaignedPrice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.cartGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartGridView.Location = new System.Drawing.Point(3, 385);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.ReadOnly = true;
            this.cartGridView.RowHeadersWidth = 51;
            this.cartGridView.RowTemplate.Height = 24;
            this.cartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartGridView.Size = new System.Drawing.Size(539, 376);
            this.cartGridView.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Ürün Adı";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Fiyat";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // CampaignedPrice
            // 
            this.CampaignedPrice.HeaderText = "KampanyalıFiyat";
            this.CampaignedPrice.MinimumWidth = 6;
            this.CampaignedPrice.Name = "CampaignedPrice";
            this.CampaignedPrice.ReadOnly = true;
            // 
            // rightTopPanel
            // 
            this.rightTopPanel.ColumnCount = 2;
            this.rightTopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightTopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rightTopPanel.Controls.Add(this.moneyPanel, 0, 0);
            this.rightTopPanel.Controls.Add(this.billPanel, 1, 0);
            this.rightTopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightTopPanel.Location = new System.Drawing.Point(548, 3);
            this.rightTopPanel.Name = "rightTopPanel";
            this.rightTopPanel.RowCount = 1;
            this.rightTopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightTopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rightTopPanel.Size = new System.Drawing.Size(540, 376);
            this.rightTopPanel.TabIndex = 2;
            // 
            // moneyPanel
            // 
            this.moneyPanel.ColumnCount = 1;
            this.moneyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.moneyPanel.Controls.Add(this.btnTL5, 0, 1);
            this.moneyPanel.Controls.Add(this.btnTL10, 0, 2);
            this.moneyPanel.Controls.Add(this.btnTL20, 0, 3);
            this.moneyPanel.Controls.Add(this.txtBalance, 0, 4);
            this.moneyPanel.Controls.Add(this.btnTL1, 0, 0);
            this.moneyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moneyPanel.Location = new System.Drawing.Point(3, 3);
            this.moneyPanel.Name = "moneyPanel";
            this.moneyPanel.RowCount = 5;
            this.moneyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.moneyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.moneyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.moneyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.moneyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.moneyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.moneyPanel.Size = new System.Drawing.Size(264, 370);
            this.moneyPanel.TabIndex = 0;
            this.moneyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.moneyPanel_Paint);
            // 
            // btnTL5
            // 
            this.btnTL5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTL5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTL5.Location = new System.Drawing.Point(3, 77);
            this.btnTL5.Name = "btnTL5";
            this.btnTL5.Size = new System.Drawing.Size(258, 68);
            this.btnTL5.TabIndex = 0;
            this.btnTL5.Text = "5 ₺";
            this.btnTL5.UseVisualStyleBackColor = true;
            this.btnTL5.Click += new System.EventHandler(this.InsertMoney);
            // 
            // btnTL10
            // 
            this.btnTL10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTL10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTL10.Location = new System.Drawing.Point(3, 151);
            this.btnTL10.Name = "btnTL10";
            this.btnTL10.Size = new System.Drawing.Size(258, 68);
            this.btnTL10.TabIndex = 1;
            this.btnTL10.Text = "10 ₺";
            this.btnTL10.UseVisualStyleBackColor = true;
            this.btnTL10.Click += new System.EventHandler(this.InsertMoney);
            // 
            // btnTL20
            // 
            this.btnTL20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTL20.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTL20.Location = new System.Drawing.Point(3, 225);
            this.btnTL20.Name = "btnTL20";
            this.btnTL20.Size = new System.Drawing.Size(258, 68);
            this.btnTL20.TabIndex = 2;
            this.btnTL20.Text = "20 ₺";
            this.btnTL20.UseVisualStyleBackColor = true;
            this.btnTL20.Click += new System.EventHandler(this.InsertMoney);
            // 
            // txtBalance
            // 
            this.txtBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBalance.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBalance.Location = new System.Drawing.Point(3, 299);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(258, 68);
            this.txtBalance.TabIndex = 3;
            this.txtBalance.Text = "Bakiye: 0 ₺";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTL1
            // 
            this.btnTL1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTL1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTL1.Location = new System.Drawing.Point(3, 3);
            this.btnTL1.Name = "btnTL1";
            this.btnTL1.Size = new System.Drawing.Size(258, 68);
            this.btnTL1.TabIndex = 4;
            this.btnTL1.Text = "1 ₺";
            this.btnTL1.UseVisualStyleBackColor = true;
            this.btnTL1.Click += new System.EventHandler(this.InsertMoney);
            // 
            // billPanel
            // 
            this.billPanel.ColumnCount = 1;
            this.billPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.billPanel.Controls.Add(this.btnBuy, 0, 0);
            this.billPanel.Controls.Add(this.btnCancel, 0, 1);
            this.billPanel.Controls.Add(this.txtTotal, 0, 2);
            this.billPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billPanel.Location = new System.Drawing.Point(273, 3);
            this.billPanel.Name = "billPanel";
            this.billPanel.RowCount = 3;
            this.billPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.billPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.billPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.billPanel.Size = new System.Drawing.Size(264, 370);
            this.billPanel.TabIndex = 1;
            // 
            // btnBuy
            // 
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuy.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuy.Location = new System.Drawing.Point(3, 3);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(258, 142);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Alışverişi Tamamla";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(3, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(258, 142);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTotal.Location = new System.Drawing.Point(3, 299);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(258, 68);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.Text = "Toplam Tutar: 0 ₺";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(548, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 764);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "VendingMachine";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.rightTopPanel.ResumeLayout(false);
            this.moneyPanel.ResumeLayout(false);
            this.moneyPanel.PerformLayout();
            this.billPanel.ResumeLayout(false);
            this.billPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel productPanel;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DataGridView cartGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampaignedPrice;
        private System.Windows.Forms.TableLayoutPanel rightTopPanel;
        private System.Windows.Forms.TableLayoutPanel moneyPanel;
        private System.Windows.Forms.Button btnTL5;
        private System.Windows.Forms.Button btnTL10;
        private System.Windows.Forms.Button btnTL20;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnTL1;
        private System.Windows.Forms.TableLayoutPanel billPanel;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

