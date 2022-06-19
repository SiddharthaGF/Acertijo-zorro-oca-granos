namespace Acertijo01
{
    internal class BaseConocimiento
    {

        public class Estado
        {
            public IList<string> estados = new string[4];
            public Estado() { }
            public Estado(string est1, string est2, string est3, string est4) => estados = new string[] { est1, est2, est3, est4 };
        }

        private class Direccion
        {
            private IList<string> direcciones = new string[2];
            public Direccion() { }
            public Direccion(string dir1, string dir2) => direcciones = new string[] { dir1, dir2 };
        }

        public class ResolverAcertijo
        {
            private List<Estado> estados = new();
            private List<Estado> prohibidos = new();
            private List<Estado> movimientos = new();
            private List<Direccion> direcciones = new();

            public ResolverAcertijo()
            {

            }

            public void AnadirEstado(string est1, string est2, string est3, string est4) => estados.Add(new Estado(est1, est2, est3, est4));
            public void AnadirEstadoProhibido(string est1, string est2, string est3, string est4) => prohibidos.Add(new Estado(est1, est2, est3, est4));
            public void AnadirDireccion(string dir1, string dir2) => direcciones.Add(new Direccion(dir1, dir2));
            public bool DetectarEstadosProhibido(Estado estados) => !prohibidos.Contains(estados);
            public static void Escribir(string linea) => Console.WriteLine(linea);

            public static bool ComprobarMeta(IList<string> actual, IList<string> final)
            {
                var actualyfinal = actual.Zip(final, (n, w) => new { Actual = n, Final = w });
                foreach (var estado in actualyfinal)
                    if (estado.Actual != estado.Final) return false;
                return true;
            }

            public void MostrarMovimientos()
            {
                foreach (var movimiento in movimientos)
                    Escribir(ConcatenarEstados(movimiento.estados));
            }

            public string ConcatenarEstados(IList<string> estado)
            {
                string linea = string.Empty;
                foreach (var est in estado)
                    linea += est + " ";
                return linea;
            }

            public void Resolver(Estado Inicial, Estado Final)
            {

            }

        }

    }
}