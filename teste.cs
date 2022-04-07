
class Teste
{
    private double _preco;
    public Teste() { }
    public Teste(double preco) { _preco = preco; }

    public double GetPreco()
    {
        return _preco * 10;
    }
    public void SetNome(double preco)
    {
                _preco = preco * 5;
    }
}