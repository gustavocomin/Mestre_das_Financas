namespace MF.Domain.ControleMensal.Mercado.Itens.Models
{
    public class ItemDto
    {
        public string Descricao { get; set; }

        public ItemDto()
        {
        }

        public ItemDto CriaDto(string descricao)
        {
            ItemDto item = new() { Descricao = descricao };
            return item;
        }


        public List<ItemDto> CriaListaDto(List<string> descricoes)
        {
            List<ItemDto> dtos = new();

            descricoes.ForEach(x =>
            {
                ItemDto item = CriaDto(x);
                dtos.Add(item);
            });

            return dtos;
        }
    }
}