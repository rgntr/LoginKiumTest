﻿namespace LoginTestKium
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.loginButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.banknum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.TextBox();
            this.autoStocStartkButton = new System.Windows.Forms.Button();
            this.autoStocStopkButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StockBenefit = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.maxPrice = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.minPrice = new System.Windows.Forms.TextBox();
            this.minPriceTXT = new System.Windows.Forms.Label();
            this.DealPower = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dealGubun = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.LimitStockCnt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MinusStrd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PlusStrd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buyStrdBad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buyStrdNormal = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.buyStrdGood = new System.Windows.Forms.TextBox();
            this.realdatagubun = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Mingubun = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(632, 534);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(38, 33);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "로그인";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(812, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 139);
            this.listBox1.TabIndex = 2;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(38, 62);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "로그아웃";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // banknum
            // 
            this.banknum.FormattingEnabled = true;
            this.banknum.Location = new System.Drawing.Point(878, 212);
            this.banknum.Name = "banknum";
            this.banknum.Size = new System.Drawing.Size(195, 23);
            this.banknum.TabIndex = 4;
            this.banknum.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(775, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(918, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "아이디";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(816, 28);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 25);
            this.userName.TabIndex = 7;
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(973, 29);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(100, 25);
            this.userID.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "계좌번호";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(816, 258);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(257, 289);
            this.listBox4.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "제한금액";
            // 
            // totalAmount
            // 
            this.totalAmount.Location = new System.Drawing.Point(134, 24);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(122, 25);
            this.totalAmount.TabIndex = 13;
            this.totalAmount.Text = "1200000";
            this.totalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // autoStocStartkButton
            // 
            this.autoStocStartkButton.Location = new System.Drawing.Point(13, 474);
            this.autoStocStartkButton.Name = "autoStocStartkButton";
            this.autoStocStartkButton.Size = new System.Drawing.Size(150, 73);
            this.autoStocStartkButton.TabIndex = 23;
            this.autoStocStartkButton.Text = "자동매매START";
            this.autoStocStartkButton.UseVisualStyleBackColor = true;
            this.autoStocStartkButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // autoStocStopkButton
            // 
            this.autoStocStopkButton.Location = new System.Drawing.Point(195, 474);
            this.autoStocStopkButton.Name = "autoStocStopkButton";
            this.autoStocStopkButton.Size = new System.Drawing.Size(150, 73);
            this.autoStocStopkButton.TabIndex = 24;
            this.autoStocStopkButton.Text = "자동매매STOP";
            this.autoStocStopkButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TestClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StockBenefit);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.maxPrice);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.minPrice);
            this.groupBox2.Controls.Add(this.minPriceTXT);
            this.groupBox2.Controls.Add(this.DealPower);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.dealGubun);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.EndTime);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.LimitStockCnt);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.MinusStrd);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.PlusStrd);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.totalAmount);
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 347);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "주문";
            // 
            // StockBenefit
            // 
            this.StockBenefit.Location = new System.Drawing.Point(134, 306);
            this.StockBenefit.Name = "StockBenefit";
            this.StockBenefit.Size = new System.Drawing.Size(122, 25);
            this.StockBenefit.TabIndex = 34;
            this.StockBenefit.Text = "5";
            this.StockBenefit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 306);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(124, 15);
            this.label21.TabIndex = 33;
            this.label21.Text = "최소영업이익(억)";
            // 
            // maxPrice
            // 
            this.maxPrice.Location = new System.Drawing.Point(134, 273);
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(122, 25);
            this.maxPrice.TabIndex = 32;
            this.maxPrice.Text = "300000";
            this.maxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 273);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 15);
            this.label20.TabIndex = 31;
            this.label20.Text = "최대매수가격";
            // 
            // minPrice
            // 
            this.minPrice.Location = new System.Drawing.Point(134, 242);
            this.minPrice.Name = "minPrice";
            this.minPrice.Size = new System.Drawing.Size(122, 25);
            this.minPrice.TabIndex = 30;
            this.minPrice.Text = "5000";
            this.minPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minPriceTXT
            // 
            this.minPriceTXT.AutoSize = true;
            this.minPriceTXT.Location = new System.Drawing.Point(8, 242);
            this.minPriceTXT.Name = "minPriceTXT";
            this.minPriceTXT.Size = new System.Drawing.Size(97, 15);
            this.minPriceTXT.TabIndex = 29;
            this.minPriceTXT.Text = "최저매수가격";
            // 
            // DealPower
            // 
            this.DealPower.Location = new System.Drawing.Point(134, 209);
            this.DealPower.Name = "DealPower";
            this.DealPower.Size = new System.Drawing.Size(122, 25);
            this.DealPower.TabIndex = 28;
            this.DealPower.Text = "100";
            this.DealPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 209);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 27;
            this.label19.Text = "체결강도";
            // 
            // dealGubun
            // 
            this.dealGubun.FormattingEnabled = true;
            this.dealGubun.Location = new System.Drawing.Point(134, 179);
            this.dealGubun.Name = "dealGubun";
            this.dealGubun.Size = new System.Drawing.Size(122, 23);
            this.dealGubun.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 24;
            this.label18.Text = "구매방법";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "종료시간";
            // 
            // EndTime
            // 
            this.EndTime.Location = new System.Drawing.Point(134, 148);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(122, 25);
            this.EndTime.TabIndex = 21;
            this.EndTime.Text = "15:20:00";
            this.EndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndTime.TextChanged += new System.EventHandler(this.EndTime_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 15);
            this.label16.TabIndex = 20;
            this.label16.Text = "최대매수주식수";
            // 
            // LimitStockCnt
            // 
            this.LimitStockCnt.Location = new System.Drawing.Point(134, 117);
            this.LimitStockCnt.Name = "LimitStockCnt";
            this.LimitStockCnt.Size = new System.Drawing.Size(122, 25);
            this.LimitStockCnt.TabIndex = 19;
            this.LimitStockCnt.Text = "4";
            this.LimitStockCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LimitStockCnt.TextChanged += new System.EventHandler(this.LimitStockCnt_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "손절매도기준";
            // 
            // MinusStrd
            // 
            this.MinusStrd.Location = new System.Drawing.Point(134, 87);
            this.MinusStrd.Name = "MinusStrd";
            this.MinusStrd.Size = new System.Drawing.Size(122, 25);
            this.MinusStrd.TabIndex = 17;
            this.MinusStrd.Text = "-7";
            this.MinusStrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "손익매도기준";
            // 
            // PlusStrd
            // 
            this.PlusStrd.Location = new System.Drawing.Point(134, 55);
            this.PlusStrd.Name = "PlusStrd";
            this.PlusStrd.Size = new System.Drawing.Size(122, 25);
            this.PlusStrd.TabIndex = 15;
            this.PlusStrd.Text = "5";
            this.PlusStrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.realdatagubun);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.buyStrdBad);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.buyStrdNormal);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.buyStrdGood);
            this.groupBox1.Location = new System.Drawing.Point(362, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 163);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주문";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "하락장 매수기준";
            // 
            // buyStrdBad
            // 
            this.buyStrdBad.Location = new System.Drawing.Point(146, 86);
            this.buyStrdBad.Name = "buyStrdBad";
            this.buyStrdBad.Size = new System.Drawing.Size(122, 25);
            this.buyStrdBad.TabIndex = 17;
            this.buyStrdBad.Text = "-5";
            this.buyStrdBad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "보통장 매수기준";
            // 
            // buyStrdNormal
            // 
            this.buyStrdNormal.Location = new System.Drawing.Point(146, 55);
            this.buyStrdNormal.Name = "buyStrdNormal";
            this.buyStrdNormal.Size = new System.Drawing.Size(122, 25);
            this.buyStrdNormal.TabIndex = 15;
            this.buyStrdNormal.Text = "-3";
            this.buyStrdNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 15);
            this.label22.TabIndex = 14;
            this.label22.Text = "장좋은날 매수기준";
            // 
            // buyStrdGood
            // 
            this.buyStrdGood.Location = new System.Drawing.Point(146, 24);
            this.buyStrdGood.Name = "buyStrdGood";
            this.buyStrdGood.Size = new System.Drawing.Size(122, 25);
            this.buyStrdGood.TabIndex = 13;
            this.buyStrdGood.Text = "-2";
            this.buyStrdGood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // realdatagubun
            // 
            this.realdatagubun.FormattingEnabled = true;
            this.realdatagubun.Location = new System.Drawing.Point(146, 120);
            this.realdatagubun.Name = "realdatagubun";
            this.realdatagubun.Size = new System.Drawing.Size(122, 23);
            this.realdatagubun.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "실시간데이터구분";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Mingubun);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(362, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 163);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "급등주 파라미터";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "분봉구분";
            // 
            // Mingubun
            // 
            this.Mingubun.FormattingEnabled = true;
            this.Mingubun.Location = new System.Drawing.Point(146, 27);
            this.Mingubun.Name = "Mingubun";
            this.Mingubun.Size = new System.Drawing.Size(122, 23);
            this.Mingubun.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 596);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.autoStocStopkButton);
            this.Controls.Add(this.autoStocStartkButton);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.banknum);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Name = "Form1";
            this.Text = "주식자동매매프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ComboBox banknum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button autoStocStartkButton;
        private System.Windows.Forms.Button autoStocStopkButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox totalAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MinusStrd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox PlusStrd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox LimitStockCnt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox EndTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox dealGubun;
        private System.Windows.Forms.TextBox maxPrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox minPrice;
        private System.Windows.Forms.Label minPriceTXT;
        private System.Windows.Forms.TextBox DealPower;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox StockBenefit;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox buyStrdBad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox buyStrdNormal;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox buyStrdGood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox realdatagubun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Mingubun;
        private System.Windows.Forms.Label label8;
    }
}
