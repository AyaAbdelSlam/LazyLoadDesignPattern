namespace LazyLoadDesignPattern.ValueHolder
{
    public interface IValueLoader<T>
    {
        T Load();
    }
}