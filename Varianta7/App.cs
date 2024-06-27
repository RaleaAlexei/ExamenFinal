using Microsoft.EntityFrameworkCore;
using System.Text;
using Varianta7.Classes;
using Varianta7.Forms;
using Varianta7.UserControls;

namespace Varianta7
{
    internal partial class App : Form
    {
        private SalonContext Context { get; set; }
        public App()
        {
            Context = new();
            InitializeComponent();
            LoadServicii();
            LoadProgramari();
        }
        private void btnAddServiciu_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.FormServiciu();
            dialog.btnSave.Click += (s, ev) =>
            {
                Serviciu newServiciu = dialog.ToServiciu();
                Context.Servicii.Add(newServiciu);
                Context.SaveChanges();
                dialog.Close();
                MessageBox.Show("Serviciul a fost adaugat cu succes!");
                LoadServicii();
            };
            dialog.ShowDialog();
        }
        private void LoadServicii(List<Serviciu>? servicii = null)
        {
            flpServicii.Controls.Clear();
            if (servicii == null)
                servicii = Context.Servicii.ToList();
            foreach (var serviciu in servicii)
            {
                ServiciuControl control = new UserControls.ServiciuControl(serviciu);
                control.btnDelete.Click += (s, ev) =>
                {
                    DialogResult result = MessageBox.Show("Confirmati stergerea?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var serviciuToDelete = Context.Servicii.Find(serviciu.CodServiciu);
                        if (serviciuToDelete != null)
                        {
                            Context.Servicii.Remove(serviciuToDelete);
                            Context.SaveChanges();
                            MessageBox.Show("Serviciul a fost șters cu succes!", "Ștergere reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Serviciul nu a fost găsit în baza de date.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        LoadServicii();
                    }
                };
                control.btnEdit.Click += (sender, e) =>
                {
                    using (var dialog = new FormServiciu())
                    {
                        dialog.FromServiciu(serviciu);
                        dialog.btnSave.Text = "Salveaza";
                        dialog.btnSave.Click += (s, e) =>
                        {
                            Serviciu modified = dialog.ToServiciu();
                            var existingEntity = Context.Servicii.Local.FirstOrDefault(e => e.CodServiciu == serviciu.CodServiciu);
                            if (existingEntity != null)
                            {
                                existingEntity.Denumirea = modified.Denumirea;
                                existingEntity.Pret = modified.Pret;
                                existingEntity.Durata = modified.Durata;
                            }
                            try
                            {
                                Context.SaveChanges();
                                MessageBox.Show("Serviciul a fost actualizat cu succes!");
                            }
                            catch (DbUpdateException ex)
                            {
                                MessageBox.Show($"Eroare la actualizarea serviciului: {ex.Message}");
                            }
                            finally
                            {
                                dialog.Close();
                            }
                        };
                        dialog.ShowDialog();
                        LoadServicii();
                    }
                };
                flpServicii.Controls.Add(control);
            }
            flpServicii.Padding = new Padding((flpServicii.Width - flpServicii.PreferredSize.Width) / 2, 0, 0, 0);

        }
        private void LoadProgramari(List<Programari>? programari = null)
        {
            flpProgramari.Controls.Clear();
            if (programari == null)
                programari = Context.Programari.Include("Serviciu").ToList();
            foreach (var programare in programari)
            {
                ProgramareControl control = new(programare);
                control.btnDelete.Click += (s, ev) =>
                {
                    DialogResult result = MessageBox.Show("Confirmati stergerea?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var programareToDelete = Context.Programari.Find(programare.CodProgramare);
                        if (programareToDelete != null)
                        {
                            Context.Programari.Remove(programareToDelete);
                            Context.SaveChanges();
                            MessageBox.Show("Programarea a fost ștearsă cu succes!", "Ștergere reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Programarea nu a fost găsită în baza de date.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        LoadProgramari();
                    }
                };
                control.btnEdit.Click += (sender, e) =>
                {
                    using (var dialog = new FormProgramari())
                    {
                        dialog.InitializeEditProgramare(programare);
                        dialog.btnSave.Text = "Salveaza";
                        dialog.btnSave.Click += (s, e) =>
                        {
                            Programari modified = dialog.ToProgramari();
                            var existingEntity = Context.Programari.Local.FirstOrDefault(e => e.CodProgramare == programare.CodProgramare);
                            if (existingEntity != null)
                            {
                                existingEntity.NumeClient = modified.NumeClient;
                                existingEntity.Telefon = modified.Telefon;
                                existingEntity.DataProgramarii = modified.DataProgramarii;
                                existingEntity.OraProgramarii = modified.OraProgramarii;
                                existingEntity.CodServiciu = modified.CodServiciu;
                                existingEntity.Mester = modified.Mester;
                            }
                            try
                            {
                                Context.SaveChanges();
                                MessageBox.Show("Programarea a fost actualizată cu succes!");
                            }
                            catch (DbUpdateException ex)
                            {
                                MessageBox.Show($"Eroare la actualizarea programării: {ex.Message}");
                            }
                            finally
                            {
                                dialog.Close();
                            }
                            LoadProgramari();
                        };
                        dialog.ShowDialog();
                    }
                };

                flpProgramari.Controls.Add(control);
            }
            flpProgramari.Padding = new Padding((flpProgramari.Width - flpProgramari.PreferredSize.Width) / 2, 0, 0, 0);
        }
        private void btnAddProgramari_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.FormProgramari();
            dialog.btnSave.Click += (s, ev) =>
            {
                Programari newServiciu = dialog.ToProgramari();
                Context.Programari.Add(newServiciu);
                Context.SaveChanges();
                dialog.Close();
                MessageBox.Show("Programarea a fost adaugat cu succes!");
                LoadProgramari();
            };
            dialog.ShowDialog();
        }

        private void dtpOraProgramarii_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string searchText = tbxQuery.Text.Trim().ToLower();
            var query = Context.Programari.AsQueryable();
            if (!string.IsNullOrEmpty(searchText))
            {
                query = query.Where(p =>
                    p.NumeClient.ToLower().Contains(searchText) ||
                    p.Telefon.ToLower().Contains(searchText) ||
                    p.Mester.ToLower().Contains(searchText) ||
                    p.Serviciu.Denumirea.ToLower().Contains(searchText)
                );
            }
            LoadProgramari([.. query]);
        }

        private void btnCautaServiciu_Click(object sender, EventArgs e)
        {
            string searchText = tbxQueryServiciu.Text.Trim().ToLower();

            var query = Context.Servicii.AsQueryable();

            if (!string.IsNullOrEmpty(searchText))
            {
                query = query.Where(s =>
                    s.Denumirea.ToLower().Contains(searchText)
                );
            }

            LoadServicii([.. query]);
        }

        private void lblRaport_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex == 2)
            {
                int countServicii = Context.Servicii.Count();
                int countProgramari = Context.Programari.Count();
                decimal averagePretServicii = Context.Servicii
                    .ToList()
                    .Average(s => s.Pret);
                var programariPerServiciu = Context.Programari
                    .GroupBy(p => p.CodServiciu)
                    .Select(g => new
                    {
                        CodServiciu = g.Key,
                        Count = g.Count()
                    })
                    .ToList();
                StringBuilder summaryBuilder = new StringBuilder();
                summaryBuilder.AppendLine($"Total Servicii: {countServicii}");
                summaryBuilder.AppendLine($"Total Programari: {countProgramari}");
                summaryBuilder.AppendLine($"Average Pret of Servicii: {averagePretServicii:F2}");

                summaryBuilder.AppendLine("Programari per Serviciu:");
                foreach (var item in programariPerServiciu)
                {
                    var serviciu = Context.Servicii.Find(item.CodServiciu);
                    if (serviciu != null)
                    {
                        summaryBuilder.AppendLine($"- {serviciu.Denumirea}: {item.Count}");
                    }
                }
                lblRaport.Text = summaryBuilder.ToString();
            }
        }
    }
}
