namespace ConsoleDrawer
{
    public static class IListExtensions
    {
        public static T? GetFirst<T>( this ILista<T> lista)
        {
            if(lista == null)
            {
                return default(T);
            }

            return lista.GetAt(0);
        }
    }
}