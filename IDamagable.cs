namespace InterfaceAbstractDemo
{
    public interface IDamagable
    {
        // classes that implement this interface MUST have Health
        int Health { get; set; }

        // classes that implement this interface MUST have a method with this signuatrue (name, return type, params)
        int TakeDamage(int amnt);
    }
}