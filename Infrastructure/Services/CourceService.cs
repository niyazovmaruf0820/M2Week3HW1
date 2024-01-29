using Domain.Models;
namespace Infrastructure.Services;

public class CourceService
{
    public CourceService() {}
    List<Cource> _cource = new List<Cource>();

    public List<Cource> GetCource(){
        return _cource;
    }
    public void AddCource(Cource cource){
        _cource.Add(cource);
    }
    public string UpdateInfoOfCource(Cource UpdatedCource){
        foreach (var cource in _cource)
        {
            if (cource.Id == UpdatedCource.Id)
            {
                cource.Title = UpdatedCource.Title;
                cource.Description = UpdatedCource.Description;
                cource.Fee = UpdatedCource.Fee;
                cource.HasDiscount = UpdatedCource.HasDiscount;
                return "Cource's info is updated";
            }
        }
        return "Cource not found";
    }
    public string DeleteCource(int id){
        foreach (var cource in _cource)
        {
            if (cource .Id == id)
            {
                _cource.Remove(cource);
                return "Cource deleted";
            }
        }
        return "Cource not found";
    }
}
