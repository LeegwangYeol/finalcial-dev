using System;
using System.Drawing;
using System.Windows.Forms;

namespace Financial
{
    public partial class Financial : Form
    {
        // 디자인 요소들
        internal Panel dashboardPanel;
        internal Label dashboardTitle;
        internal Panel accountsOverviewPanel;
        internal Panel recentTransactionsPanel;
        internal Panel quickBillPayPanel;
        internal Panel businessMetricsPanel;
        internal Label balanceLabel;
        internal Button addButton;
        internal Button sendButton;
        internal Button requestButton;
        internal Button moreButton;
        internal Button detailsButton;

        /// <summary>
        /// 디자이너 지원에 필요한 변수입니다.
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
            this.SuspendLayout();
            
            // 폼 설정
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Name = "Financial";
            this.Text = "Financial Dashboard";
            this.BackColor = Color.FromArgb(255, 255, 255);
            
            // 대시보드 패널 생성
            CreateDashboardPanel();
            
            this.ResumeLayout(false);
        }

        private void CreateDashboardPanel()
        {
            // 대시보드 패널
            dashboardPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20),
                AutoScroll = true
            };
            this.Controls.Add(dashboardPanel);

            // 대시보드 제목
            dashboardTitle = new Label
            {
                Text = "Dashboard",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(20, 20),
                AutoSize = true
            };
            dashboardPanel.Controls.Add(dashboardTitle);

            // 메인 컨텐츠 영역
            int yPos = dashboardTitle.Bottom + 20;
            
            // 계정 개요 패널
            accountsOverviewPanel = CreateAccountsOverviewPanel();
            accountsOverviewPanel.Location = new Point(20, yPos);
            accountsOverviewPanel.Size = new Size(350, 300);
            dashboardPanel.Controls.Add(accountsOverviewPanel);

            // 최근 거래 패널
            recentTransactionsPanel = CreateRecentTransactionsPanel();
            recentTransactionsPanel.Location = new Point(390, yPos);
            recentTransactionsPanel.Size = new Size(350, 300);
            dashboardPanel.Controls.Add(recentTransactionsPanel);

            // 빠른 청구서 지불 패널
            quickBillPayPanel = CreateQuickBillPayPanel();
            quickBillPayPanel.Location = new Point(760, yPos);
            quickBillPayPanel.Size = new Size(350, 300);
            dashboardPanel.Controls.Add(quickBillPayPanel);

            // 비즈니스 지표 패널
            businessMetricsPanel = CreateBusinessMetricsPanel();
            businessMetricsPanel.Location = new Point(20, yPos + 320);
            businessMetricsPanel.Size = new Size(1090, 300);
            dashboardPanel.Controls.Add(businessMetricsPanel);
        }

        private Panel CreateAccountsOverviewPanel()
        {
            Panel panel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            // 패널 제목
            Label titleLabel = new Label
            {
                Text = "Accounts Overview",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(15, 15),
                AutoSize = true
            };
            panel.Controls.Add(titleLabel);

            // 총 잔액 표시 (임시 데이터)
            decimal totalBalance = 6446500; // 실제로는 로직에서 가져와야 함

            balanceLabel = new Label
            {
                Text = "$" + totalBalance.ToString("N0"),
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Location = new Point(15, 45),
                AutoSize = true
            };
            panel.Controls.Add(balanceLabel);

            Label balanceDescLabel = new Label
            {
                Text = "Total balance across all accounts",
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.Gray,
                Location = new Point(15, 75),
                AutoSize = true
            };
            panel.Controls.Add(balanceDescLabel);

            // 계정 목록 (임시 데이터)
            string[] accountNames = { "Checking", "Savings", "Investment" };
            decimal[] accountBalances = { 7500, 560000, 5879000 };

            int yPos = 100;
            for (int i = 0; i < accountNames.Length; i++)
            {
                Label accountNameLabel = new Label
                {
                    Text = accountNames[i],
                    Font = new Font("Segoe UI", 9),
                    ForeColor = Color.Gray,
                    Location = new Point(15, yPos),
                    AutoSize = true
                };
                panel.Controls.Add(accountNameLabel);

                Label accountBalanceLabel = new Label
                {
                    Text = "$" + accountBalances[i].ToString("N0"),
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Location = new Point(panel.Width - 80, yPos),
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight
                };
                panel.Controls.Add(accountBalanceLabel);

                yPos += 25;
            }

            // 버튼 영역
            yPos += 15;
            
            addButton = new Button
            {
                Text = "Add",
                Location = new Point(15, yPos),
                Size = new Size(150, 30),
                BackColor = Color.FromArgb(59, 130, 246),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            panel.Controls.Add(addButton);

            sendButton = new Button
            {
                Text = "Send",
                Location = new Point(panel.Width - 165, yPos),
                Size = new Size(150, 30),
                BackColor = Color.FromArgb(59, 130, 246),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            panel.Controls.Add(sendButton);

            yPos += 40;
            
            requestButton = new Button
            {
                Text = "Request",
                Location = new Point(15, yPos),
                Size = new Size(150, 30),
                BackColor = Color.FromArgb(59, 130, 246),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            panel.Controls.Add(requestButton);

            moreButton = new Button
            {
                Text = "More",
                Location = new Point(panel.Width - 165, yPos),
                Size = new Size(150, 30),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            moreButton.FlatAppearance.BorderColor = Color.Gray;
            panel.Controls.Add(moreButton);

            return panel;
        }

        private Panel CreateRecentTransactionsPanel()
        {
            Panel panel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                AutoScroll = true
            };

            // 임시 거래 데이터
            string[] names = { "Alice Johnson", "Bob Smith", "Charlie Brown", "Diana Martinez", "Ethan Williams" };
            string[] emails = { "alice@example.com", "bob@example.com", "charlie@example.com", "diana@example.com", "ethan@example.com" };
            string[] amounts = { "+$350.00", "-$120.50", "+$1,000.00", "-$50.75", "+$720.00" };
            string[] dates = { "2023-07-20", "2023-07-19", "2023-07-18", "2023-07-17", "2023-07-16" };

            int yPos = 15;
            for (int i = 0; i < names.Length; i++)
            {
                Panel transactionPanel = new Panel
                {
                    Location = new Point(10, yPos),
                    Size = new Size(panel.Width - 22, 60),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };
                panel.Controls.Add(transactionPanel);

                // 아바타 (원형 대신 사각형으로 대체)
                Panel avatarPanel = new Panel
                {
                    Location = new Point(10, 10),
                    Size = new Size(40, 40),
                    BackColor = Color.LightGray
                };
                transactionPanel.Controls.Add(avatarPanel);

                Label avatarLabel = new Label
                {
                    Text = names[i].Substring(0, 1),
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(0, 0),
                    Size = new Size(40, 40)
                };
                avatarPanel.Controls.Add(avatarLabel);

                // 이름 및 이메일
                Label nameLabel = new Label
                {
                    Text = names[i],
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Location = new Point(60, 10),
                    AutoSize = true
                };
                transactionPanel.Controls.Add(nameLabel);

                Label emailLabel = new Label
                {
                    Text = emails[i],
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.Gray,
                    Location = new Point(60, 30),
                    AutoSize = true
                };
                transactionPanel.Controls.Add(emailLabel);

                // 금액 및 날짜
                Label amountLabel = new Label
                {
                    Text = amounts[i],
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = amounts[i].StartsWith("+") ? Color.Green : Color.Red,
                    Location = new Point(transactionPanel.Width - 80, 10),
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight
                };
                transactionPanel.Controls.Add(amountLabel);

                Label dateLabel = new Label
                {
                    Text = dates[i],
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.Gray,
                    Location = new Point(transactionPanel.Width - 80, 30),
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight
                };
                transactionPanel.Controls.Add(dateLabel);

                yPos += 70;
            }

            return panel;
        }

        private Panel CreateQuickBillPayPanel()
        {
            Panel panel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            // 패널 제목
            Label titleLabel = new Label
            {
                Text = "Quick Bill Pay",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(15, 15),
                AutoSize = true
            };
            panel.Controls.Add(titleLabel);

            // 청구서 목록 (임시 데이터)
            string[] billNames = { "Electricity Bill", "Internet Service", "Credit Card Payment", "Water Bill" };
            decimal[] billAmounts = { 85, 60, 500, 45 };
            string[] dueDates = { "2023-07-15", "2023-07-18", "2023-07-25", "2023-07-30" };

            int yPos = 50;
            for (int i = 0; i < billNames.Length; i++)
            {
                Label billNameLabel = new Label
                {
                    Text = billNames[i],
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Location = new Point(15, yPos),
                    AutoSize = true
                };
                panel.Controls.Add(billNameLabel);

                Label dueDateLabel = new Label
                {
                    Text = "Due: " + dueDates[i],
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.Gray,
                    Location = new Point(15, yPos + 20),
                    AutoSize = true
                };
                panel.Controls.Add(dueDateLabel);

                Label amountLabel = new Label
                {
                    Text = "$" + billAmounts[i].ToString(),
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Location = new Point(panel.Width - 100, yPos + 10),
                    AutoSize = true
                };
                panel.Controls.Add(amountLabel);

                Button payButton = new Button
                {
                    Text = "Pay",
                    Location = new Point(panel.Width - 60, yPos + 5),
                    Size = new Size(40, 25),
                    BackColor = Color.White,
                    ForeColor = Color.Black,
                    FlatStyle = FlatStyle.Flat
                };
                payButton.FlatAppearance.BorderColor = Color.Gray;
                panel.Controls.Add(payButton);

                yPos += 50;
            }

            return panel;
        }

        private Panel CreateBusinessMetricsPanel()
        {
            Panel panel = new Panel
            {
                BorderStyle = BorderStyle.None,
                BackColor = Color.Transparent
            };

            // 패널 제목 및 버튼
            Label titleLabel = new Label
            {
                Text = "Business Metrics",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(0, 0),
                AutoSize = true
            };
            panel.Controls.Add(titleLabel);

            detailsButton = new Button
            {
                Text = "View Details",
                Location = new Point(panel.Width - 120, 0),
                Size = new Size(120, 30),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat
            };
            detailsButton.FlatAppearance.BorderColor = Color.Gray;
            panel.Controls.Add(detailsButton);

            // 지표 카드 생성 (임시 데이터)
            string[] titles = { "Revenue Growth", "Customer Acquisition", "Average Order Value" };
            string[] subtitles = { "Monthly revenue target", "New customers this quarter", "Target AOV for Q3" };
            string[] statuses = { "On Track", "Behind", "Ahead" };
            int[] progresses = { 75, 60, 110 };
            decimal[] targets = { 100000, 1000, 150 };
            decimal[] currents = { 75000, 600, 165 };
            string[] units = { "$", "", "$" };

            int xPos = 0;
            int yPos = 40;
            int cardWidth = 350;
            int cardHeight = 200;
            int cardMargin = 20;

            for (int i = 0; i < titles.Length; i++)
            {
                Panel metricPanel = new Panel
                {
                    Location = new Point(xPos, yPos),
                    Size = new Size(cardWidth, cardHeight),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };
                panel.Controls.Add(metricPanel);

                // 카드 제목
                Label metricTitleLabel = new Label
                {
                    Text = titles[i],
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(15, 15),
                    AutoSize = true
                };
                metricPanel.Controls.Add(metricTitleLabel);

                // 부제목
                Label subtitleLabel = new Label
                {
                    Text = subtitles[i],
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.Gray,
                    Location = new Point(15, 40),
                    AutoSize = true
                };
                metricPanel.Controls.Add(subtitleLabel);

                // 상태 표시
                Panel statusPanel = new Panel
                {
                    Location = new Point(15, 65),
                    Size = new Size(80, 20),
                    BackColor = GetStatusColor(statuses[i])
                };
                metricPanel.Controls.Add(statusPanel);

                Label statusLabel = new Label
                {
                    Text = statuses[i],
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(0, 0),
                    Size = new Size(80, 20)
                };
                statusPanel.Controls.Add(statusLabel);

                // 진행 상황
                Label progressLabel = new Label
                {
                    Text = $"{currents[i]} / {targets[i]} {units[i]}",
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.Gray,
                    Location = new Point(metricPanel.Width - 120, 65),
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight
                };
                metricPanel.Controls.Add(progressLabel);

                // 프로그레스 바 배경
                Panel progressBgPanel = new Panel
                {
                    Location = new Point(15, 95),
                    Size = new Size(metricPanel.Width - 30, 5),
                    BackColor = Color.LightGray
                };
                metricPanel.Controls.Add(progressBgPanel);

                // 프로그레스 바
                Panel progressBarPanel = new Panel
                {
                    Location = new Point(0, 0),
                    Size = new Size((int)((metricPanel.Width - 30) * Math.Min(progresses[i], 100) / 100.0), 5),
                    BackColor = Color.FromArgb(59, 130, 246)
                };
                progressBgPanel.Controls.Add(progressBarPanel);

                // 목표 및 완료율
                Label targetLabel = new Label
                {
                    Text = $"{units[i]}{targets[i].ToString("N0")}",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Location = new Point(15, 110),
                    AutoSize = true
                };
                metricPanel.Controls.Add(targetLabel);

                Label completeLabel = new Label
                {
                    Text = $"{progresses[i]}% complete",
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.Gray,
                    Location = new Point(metricPanel.Width - 100, 110),
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight
                };
                metricPanel.Controls.Add(completeLabel);

                xPos += cardWidth + cardMargin;
            }

            return panel;
        }

        private Color GetStatusColor(string status)
        {
            switch (status)
            {
                case "On Track":
                    return Color.FromArgb(34, 197, 94);
                case "Behind":
                    return Color.FromArgb(239, 68, 68);
                case "Ahead":
                    return Color.FromArgb(59, 130, 246);
                default:
                    return Color.Gray;
            }
        }

        #endregion
    }
}