using Modelo;

namespace Aula05.ViewModels{
         public class OrderViewModel{
            public List<Customer> Customers { get; set; } = [];
            public int? CustomerId { get; set; }
            public List<SelectedItems>? SelectedItems { get; set; }



        }

        public class SelectedItems {

            public bool IsSelected { get; set; } = false;
            public OrderItem OrderItem { get; set; } = null!;
        }

    }

