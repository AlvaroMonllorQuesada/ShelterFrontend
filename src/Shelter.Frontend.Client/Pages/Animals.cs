using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

public partial class Animals
{
    private List<Elemento> elementos = new();

    [Inject] private IElementoService ElementoService { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        elementos = await ElementoService.ObtenerElementosAsync();
    }
}
