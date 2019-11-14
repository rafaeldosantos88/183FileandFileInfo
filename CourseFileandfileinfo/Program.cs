using System;
using System.IO;

namespace CourseFileandfileinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string origemCaminho = @"c:\temp\crackeando.txt";     //Caminho do arquivo e sua localização
            string destinoCaminho = @"c:\temp\vocefoihackeado.txt";    //Caminho de destino

            try
            {
                FileInfo fileInfo = new FileInfo(origemCaminho);      //Foi instanciado um objeto do tipo file info.Recebendo como argumento origemCaminho.Ou seja vou instanciar um objeto associado ao caminho que Eu passar
                fileInfo.CopyTo(destinoCaminho);                     //Arquivo foi instanciado acima  e faz uma copia
                string[] lines = File.ReadAllLines(origemCaminho); 
                foreach(string line in lines)                       //☺Para cada string line contido no meu vetor lines↓
                {
                    Console.WriteLine(line);                       //Vou mostrar na tela↑
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu!");             //caso ocorra um erro vai dar uma exceção
                Console.WriteLine(e.Message);

            }


        }
    }
}