using TECNM.PRACTICA2.CORE.Entities;
using TECNM.PRACTICA2.CORE.Services.Interfaces;
using TECNM.PRACTICA2.CORE.Managers.Interfaces;
namespace TECNM.PRACTICA2.CORE.Managers;
public class pmManager : ipmManager{
    private readonly ipmService _service;

    public pmManager(ipmService service){
        _service = service;
    }

    public Result GetResult(Data data){
        return _service.processData(data);
    }
}


