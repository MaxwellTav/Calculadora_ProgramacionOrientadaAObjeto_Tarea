namespace Calculadora_ProgramacionOrientadaAObjeto_Tarea.Classes
{
    class Operation
    {
        public double Result;

        public void DoOperation(double Num1, double Num2, OperationEnum _enum)
        {
            //Elegir la operación.
            switch (_enum)
            {
                case OperationEnum.Suma:
                    Result = Num1 + Num2;
                    break;

                case OperationEnum.Resta:
                    Result = Num1 - Num2;
                    break;

                case OperationEnum.Multiplicacion:
                    Result = Num1 * Num2;
                    break;

                case OperationEnum.Division:
                    Result = Num1 / Num2;
                    break;
            }
        }
    }

    public enum OperationEnum
    {
        Suma,
        Resta,
        Multiplicacion /*No le pongo acento por la coherencia en la programación*/,
        Division /*No le pongo acento por la coherencia en la programación*/
    }
}
