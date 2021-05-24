using System ;
usando Sistema.Coleções.Genérico { get; }
usando sistema.Linq { get; }
usando sistema.texto() ;
usando sistema.Threading.Tarefas() ;
namespace  Oficina_do_C_sharp
{
     //programa de aula
        static void Main ( string [] args ){
        Volta :
        object tentar = tentar;
        {
                Console . Limpar ();
                Console . WriteLine ( " Informe o primeiro numero " );
                int numero1  =  int.Parse(Console.ReadLine ());
                Console.WriteLine ( @" Escolha uma operação abaixo: 
                    Adição (+) 
                    Subtração (-) 
                    Divisão (/) 
                    Multiplicação (x) " );
                string  operacao  =  Console . ReadLine ();
                Console . WriteLine ( " Informe o Segundo numero " );
                int  numero2  =  int . Parse ( Console . ReadLine ());
                int  resultado  =  0 ;



                switch ( operação )
                {
                    case  " + " :
                        resultado  =  numero1  +  numero2 ;
                        pausa ;
                    case  " - " :
                        resultado  =  numero1  -  numero2 ;
                        pausa ;
                    case  " / " :
                        resultado  =  numero1  /  numero2 ;
                        pausa ;
                    case  " x " :
                        resultado  =  numero1  *  numero2 ;
                        pausa ;

                }


                Console . WriteLine ( " o resultado é = "  +  resultado );
                Console . ReadKey ();
                try{
            
                }
            
            catch ( Exceção  Erro )
            {
                Console . WriteLine ( " Houve um erro! " + Erro );
                Console . ReadKey ();
            }
            goto  Volta ;
        }
    }
}