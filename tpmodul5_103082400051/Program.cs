// See https://aka.ms/new-console-template for more information
using tpmodul5_103082400051;

HaloGeneric halo = new HaloGeneric();
halo.SapaUser("arkalevi");

DataGeneric<string> dataNIM = new DataGeneric<string>("103082400051");
dataNIM.PrintData();

public class DataGeneric<T> {
    private T data;
    public DataGeneric(T data) { this.data = data; }
    public void PrintData() {
        Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
    }
}