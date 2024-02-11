using TECNM.PRACTICA2.CORE.Entities;
using TECNM.PRACTICA2.CORE.Services.Interfaces;
namespace TECNM.PRACTICA2.CORE.Services;

public class pmService:ipmService{

    public Result processData(Data data){

        var datos = new Result();
        datos.PesoMarte = (float) (data.Peso * 3.711);
        datos.PesoMarte = (float) (datos.PesoMarte / 9.81);
        return datos;
    }
}

