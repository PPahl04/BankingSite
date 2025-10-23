using System.Data;
using System.Windows.Forms;

namespace BankingSite
{
	public partial class OwnedAccounts : Form
	{
		public OwnedAccounts(DataTable data)
		{
			InitializeComponent();

			dgvOwnedAccounts.DataSource = data;
			dgvOwnedAccounts.Refresh();
		}
	}
}