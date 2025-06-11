using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiControls.Models
{
    public class FotoViewModel
    {
        public ObservableCollection<Foto> fotos { get; set; }

        public ObservableCollection<Foto> Fotos
        {
            get { return fotos; }
            set { fotos = value; }
        }

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto() { Nome = "Andrônema", ImagemUrl = "dotnet_bot.png" },
                new Foto() { Nome = "Andrônema", ImagemUrl = "dotnet_bot.png" },
                new Foto() { Nome = "Andrônema", ImagemUrl = "dotnet_bot.png" },
                new Foto() { Nome = "Andrônema", ImagemUrl = "dotnet_bot.png" },
                new Foto() { Nome = "Andrônema", ImagemUrl = "dotnet_bot.png" },
                new Foto() { Nome = "Andrônema", ImagemUrl = "dotnet_bot.png" },
                new Foto() { Nome = "Andrônema", ImagemUrl = "dotnet_bot.png" },
                new Foto() { Nome = "Andrônema", ImagemUrl = "dotnet_bot.png" },
                new Foto() { Nome = "Andrônema", ImagemUrl = "dotnet_bot.png" }
            };

        }
    }
}
