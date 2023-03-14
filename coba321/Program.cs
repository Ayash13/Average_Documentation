using System;

/// <summary>
/// Kelas utama program
/// </summary>
class Program
{
    /// <summary>
    /// Method utama program
    /// </summary>
    /// <param name="args">Argumen baris perintah</param>
    static void Main(string[] args)
    {
        bool ulang = false;
        do
        {
            Console.Write("Masukkan jumlah data: ");
            int n = int.Parse(Console.ReadLine());

            int[] angka = new int[n];

            // memasukkan data ke dalam array
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Masukkan data ke-{i + 1}: ");
                angka[i] = int.Parse(Console.ReadLine());
            }

            // menampilkan data yang telah dimasukkan
            DisplayData(angka);

            // menghitung rata-rata dan menampilkan hasilnya
            double average = HitungRata2(angka);
            Console.WriteLine($"Rata-rata: {average}");

            // menampilkan data yang lebih besar dari rata-rata
            DisplayRata2(angka, average);

            Console.Write("Apakah Anda ingin mengulang program? (Y/N): ");
            ulang = (Console.ReadLine().ToLower() == "y");
        } while (ulang);

        Console.ReadKey();
    }

    /// <summary>
    /// Method untuk menghitung rata-rata dari array
    /// </summary>
    /// <param name="angka">Array bilangan integer</param>
    /// <returns>Rata-rata bilangan array</returns>
    static double HitungRata2(int[] angka)
    {
        int sum = 0;
        foreach (int hasil in angka)
        {
            sum += hasil;
        }
        return (double)sum / angka.Length;
    }

    /// <summary>
    /// Method untuk menampilkan data dari array
    /// </summary>
    /// <param name="angka">Array bilangan integer</param>
    static void DisplayData(int[] angka)
    {
        Console.WriteLine("Data yang dimasukkan:");
        foreach (int hasil in angka)
        {
            Console.WriteLine(hasil);
        }
    }

    /// <summary>
    /// Method untuk menampilkan data yang lebih besar dari rata-rata
    /// </summary>
    /// <param name="angka">Array bilangan integer</param>
    /// <param name="average">Rata-rata dari array</param>
    static void DisplayRata2(int[] angka, double average)
    {
        Console.WriteLine($"Data yang lebih besar dari rata-rata ({average}):");
        foreach (int hasil in angka)
        {
            if (hasil > average)
            {
                Console.WriteLine(hasil);
            }
        }
    }
}
s