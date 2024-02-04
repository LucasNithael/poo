 
class Program{
  public static void Main(){
    Data x = new Data("20/02/2020");
    Console.WriteLine(x);
    
  }
}

class Data{
  private int dia, mes, ano;
    public Data(string a){
    string[] b = a.Split("/");
    this.dia = int.Parse(b[0]);
    this.mes = int.Parse(b[1]);
    this.ano = int.Parse(b[2]);
  }
  public Data(int dia, int mes, int ano){
    if(DataValida(dia, mes, ano)){
      this.dia = dia;
      this.mes = mes;
      this.ano = ano;
    }
  }
  private bool Bissexto(int ano){
    if((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0) return true;
    else return false;
  }
  private bool DataValida(int dia, int mes, int ano){
    switch(mes){
      case 1: if(dia>=1 && dia<=31) return true; break;
      case 2: if(Bissexto(ano) && dia<=29){return true; break;}
              if(dia>=1 && dia<=28){return true; break;}
              else return false; break;
      case 3: if(dia>=1 && dia<=31) return true; break;
      case 4: if(dia>=1 && dia<=30) return true; break;
      case 5: if(dia>=1 && dia<=31) return true; break;
      case 6: if(dia>=1 && dia<=30) return true; break;
      case 7: if(dia>=1 && dia<=31) return true; break;
      case 8: if(dia>=1 && dia<=31) return true; break;
      case 9: if(dia>=1 && dia<=30) return true; break;
      case 10: if(dia>=1 && dia<=31) return true; break;
      case 11: if(dia>=1 && dia<=30) return true; break;
      case 12: if(dia>=1 && dia<=31) return true; break;
      default: return false;
    } 
  }
  public override string ToString() {
    return $"{this.dia:00}/{this.mes:00}/{this.ano:0000}";
  }
}