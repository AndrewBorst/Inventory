using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Inventory.Data;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Components.Pages
{
    public partial class AddItem
    {
        // Inject ApplicationDbContext using [Inject] attribute
        [Inject]
        public ApplicationDbContext? DbContext { get; set; }
        private InventoryItem _newItem = new() { Quantity = 1};
        private string _errorMessage = string.Empty;
        private List<Lookup> _locations = new();

        protected override async Task OnInitializedAsync()
        {
            if (DbContext != null)
            {
                _locations = await DbContext.Lookups
                    .Where(l => l.Type == "inventory-location")
                    .ToListAsync();
            }
        }
        private async Task HandleValidSubmit()
        {
            if (DbContext == null)
            {
                _errorMessage = "Database context is not initialized.";
                return;
            }
            if (string.IsNullOrWhiteSpace(_newItem.Name))
            {
                _errorMessage = "Name is required.";
                return;
            }

            DbContext.InventoryItems.Add(_newItem);
            await DbContext.SaveChangesAsync();

            // Reset the form
            _newItem = new InventoryItem();
            StateHasChanged();
        }
    }
}