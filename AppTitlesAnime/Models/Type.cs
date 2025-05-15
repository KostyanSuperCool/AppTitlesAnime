namespace AppTitlesAnime.Models;

public partial class Type
{
    public short Id { get; set; }

    public string TypeName { get; set; } = null!;

    //навигационные свойства
    public virtual ICollection<AnimeTitile> AnimeTitles { get; set; } = new List<AnimeTitile>();
}
