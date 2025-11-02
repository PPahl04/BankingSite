using System.Windows.Forms;
using System.Data;

namespace BankingSite
{
	public partial class AssociatedDataTables : Form
	{
		public AssociatedDataTables(DataTable data)
		{
			InitializeComponent();

			dgvAssosiatedDataTable.DataSource = data;
			dgvAssosiatedDataTable.Refresh();
		}
	}
}