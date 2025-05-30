using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Financial
{
    // 데이터 클래스들
    public class Account
    {
        public string? Name { get; set; }
        public decimal Balance { get; set; }
    }

    public class Transaction
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Amount { get; set; }
        public string? Status { get; set; }
        public string? Date { get; set; }
        public string? Avatar { get; set; }
    }

    public class Bill
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Amount { get; set; }
        public string? DueDate { get; set; }
    }

    public class Metric
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public string? Status { get; set; }
        public int Progress { get; set; }
        public decimal Target { get; set; }
        public decimal Current { get; set; }
        public string? Unit { get; set; }
    }

    // 비즈니스 로직 클래스
    public class FinancialLogic
    {
        // 계정 정보
        private List<Account> accounts = new List<Account>
        {
            new Account { Name = "Checking", Balance = 7500 },
            new Account { Name = "Savings", Balance = 560000 },
            new Account { Name = "Investment", Balance = 5879000 }
        };

        // 최근 거래 정보
        private List<Transaction> recentTransactions = new List<Transaction>
        {
            new Transaction { Id = "1", Name = "Alice Johnson", Email = "alice@example.com", Amount = "+$350.00", Status = "success", Date = "2023-07-20" },
            new Transaction { Id = "2", Name = "Bob Smith", Email = "bob@example.com", Amount = "-$120.50", Status = "pending", Date = "2023-07-19" },
            new Transaction { Id = "3", Name = "Charlie Brown", Email = "charlie@example.com", Amount = "+$1,000.00", Status = "success", Date = "2023-07-18" },
            new Transaction { Id = "4", Name = "Diana Martinez", Email = "diana@example.com", Amount = "-$50.75", Status = "failed", Date = "2023-07-17" },
            new Transaction { Id = "5", Name = "Ethan Williams", Email = "ethan@example.com", Amount = "+$720.00", Status = "success", Date = "2023-07-16" }
        };

        // 청구서 정보
        private List<Bill> bills = new List<Bill>
        {
            new Bill { Id = 1, Name = "Electricity Bill", Amount = 85, DueDate = "2023-07-15" },
            new Bill { Id = 2, Name = "Internet Service", Amount = 60, DueDate = "2023-07-18" },
            new Bill { Id = 3, Name = "Credit Card Payment", Amount = 500, DueDate = "2023-07-25" },
            new Bill { Id = 4, Name = "Water Bill", Amount = 45, DueDate = "2023-07-30" }
        };

        // 비즈니스 지표
        private List<Metric> metrics = new List<Metric>
        {
            new Metric { Id = 1, Title = "Revenue Growth", Subtitle = "Monthly revenue target", Status = "On Track", Progress = 75, Target = 100000, Current = 75000, Unit = "$" },
            new Metric { Id = 2, Title = "Customer Acquisition", Subtitle = "New customers this quarter", Status = "Behind", Progress = 60, Target = 1000, Current = 600, Unit = "" },
            new Metric { Id = 3, Title = "Average Order Value", Subtitle = "Target AOV for Q3", Status = "Ahead", Progress = 110, Target = 150, Current = 165, Unit = "$" }
        };

        // 비즈니스 로직 메서드 추가
        public List<Account> GetAccounts()
        {
            return accounts;
        }

        public decimal GetTotalBalance()
        {
            decimal total = 0;
            foreach (var account in accounts)
            {
                total += account.Balance;
            }
            return total;
        }

        public List<Transaction> GetRecentTransactions()
        {
            return recentTransactions;
        }

        public List<Bill> GetBills()
        {
            return bills;
        }

        public List<Metric> GetMetrics()
        {
            return metrics;
        }
    }

    public partial class Financial : Form
    {
        private FinancialLogic financialLogic;

        public Financial()
        {
            InitializeComponent();
            financialLogic = new FinancialLogic();
            
            // 폼 로드 이벤트 추가
            this.Load += Financial_Load;
            
            // 버튼 이벤트 핸들러 추가
            AddButtonEventHandlers();
        }

        private void Financial_Load(object? sender, EventArgs e)
        {
            // 데이터 로드 및 UI 업데이트
            LoadAccountsData();
            LoadTransactionsData();
            LoadBillsData();
            LoadMetricsData();
            
            // 사이드바 및 헤더 이벤트 핸들러 추가
            AddSidebarEventHandlers();
            AddHeaderEventHandlers();
        }

        private void LoadAccountsData()
        {
            // 계정 데이터 로드
            var accounts = financialLogic.GetAccounts();
            decimal totalBalance = financialLogic.GetTotalBalance();

            // UI 업데이트 (계정 패널)
            if (balanceLabel != null)
            {
                balanceLabel.Text = "$" + totalBalance.ToString("N0");
            }

            // 계정 목록 업데이트 로직은 디자이너 코드에서 이미 구현됨
        }

        private void LoadTransactionsData()
        {
            // 거래 데이터 로드
            var transactions = financialLogic.GetRecentTransactions();
            
            // UI 업데이트 (거래 패널)
            // 거래 목록 업데이트 로직은 디자이너 코드에서 이미 구현됨
        }

        private void LoadBillsData()
        {
            // 청구서 데이터 로드
            var bills = financialLogic.GetBills();
            
            // UI 업데이트 (청구서 패널)
            // 청구서 목록 업데이트 로직은 디자이너 코드에서 이미 구현됨
        }

        private void LoadMetricsData()
        {
            // 지표 데이터 로드
            var metrics = financialLogic.GetMetrics();
            
            // UI 업데이트 (지표 패널)
            // 지표 목록 업데이트 로직은 디자이너 코드에서 이미 구현됨
        }

        private void AddButtonEventHandlers()
        {
            // 버튼 이벤트 핸들러 추가
            if (addButton != null)
            {
                addButton.Click += AddButton_Click;
            }
            
            if (sendButton != null)
            {
                sendButton.Click += SendButton_Click;
            }
            
            if (requestButton != null)
            {
                requestButton.Click += RequestButton_Click;
            }
            
            if (moreButton != null)
            {
                moreButton.Click += MoreButton_Click;
            }
            
            if (detailsButton != null)
            {
                detailsButton.Click += DetailsButton_Click;
            }
        }

        // 사이드바 이벤트 핸들러 추가
        private void AddSidebarEventHandlers()
        {
            // 사이드바 패널의 모든 하위 컨트롤 순회
            foreach (Control menuPanel in sidebarPanel.Controls)
            {
                if (menuPanel is Panel)
                {
                    menuPanel.Click += MenuPanel_Click;
                    
                    // 패널 내부의 모든 라벨에도 이벤트 추가
                    foreach (Control control in menuPanel.Controls)
                    {
                        if (control is Label)
                        {
                            control.Click += MenuPanel_Click;
                        }
                    }
                }
            }
        }

        // 헤더 이벤트 핸들러 추가
        private void AddHeaderEventHandlers()
        {
            if (notificationButton != null)
            {
                notificationButton.Click += NotificationButton_Click;
            }
            
            if (darkModeButton != null)
            {
                darkModeButton.Click += DarkModeButton_Click;
            }
            
            if (profileButton != null)
            {
                profileButton.Click += ProfileButton_Click;
            }
        }

        // 메뉴 패널 클릭 이벤트 핸들러
        private void MenuPanel_Click(object? sender, EventArgs e)
        {
            // 클릭된 메뉴 항목 확인
            if (sender is Control control)
            {
                // 클릭된 컨트롤이 라벨인 경우 부모 패널 찾기
                Panel? clickedPanel = null;
                
                if (control is Label label && label.Parent is Panel parentPanel)
                {
                    clickedPanel = parentPanel;
                }
                else if (control is Panel panel)
                {
                    clickedPanel = panel;
                }
                
                if (clickedPanel == null)
                {
                    return; // 유효한 패널이 없으면 종료
                }
                
                // 모든 메뉴 패널 배경색 초기화
                foreach (Control menuPanel in sidebarPanel.Controls)
                {
                    if (menuPanel is Panel)
                    {
                        menuPanel.BackColor = Color.Transparent;
                    }
                }
                
                // 클릭된 메뉴 패널 강조 표시
                clickedPanel.BackColor = Color.FromArgb(32, 32, 32);
                
                // 메뉴 항목에 따른 작업 수행
                string menuText = "";
                foreach (Control c in clickedPanel.Controls)
                {
                    if (c is Label menuLabel && menuLabel.Location.X > 40) // 메뉴 텍스트 라벨 찾기
                    {
                        menuText = menuLabel.Text;
                        break;
                    }
                }
                
                MessageBox.Show($"{menuText} 메뉴가 선택되었습니다.", "메뉴 선택", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 알림 버튼 클릭 이벤트 핸들러
        private void NotificationButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("알림 목록을 표시합니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 다크모드 전환 버튼 클릭 이벤트 핸들러
        private void DarkModeButton_Click(object? sender, EventArgs e)
        {
            // 다크모드와 라이트모드 전환 로직 (현재는 메시지만 표시)
            MessageBox.Show("테마를 전환합니다.", "테마 변경", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 프로필 버튼 클릭 이벤트 핸들러
        private void ProfileButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("프로필 정보를 표시합니다.", "프로필", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 버튼 이벤트 핸들러
        private void AddButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Add button clicked", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SendButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Send button clicked", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RequestButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Request button clicked", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MoreButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("More button clicked", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DetailsButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("View Details button clicked", "Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}