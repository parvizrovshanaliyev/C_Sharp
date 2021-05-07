using System;

#region Span and Memory Types
/*
 * ReadOnlySpan<T> & ReadOnlyMemory<T>
 *
 * Span RAM-daki mueyyen bir yeri temsil eden ve o yer uzerinde emeliyyatlar
 * apara bilmeyimize imkan yaradan bir struct-dir.
 *
 * ArraySegment ve StringSegment-den ferqli olaraq array ve string-lerdern basqa datalarla
 * islemeye imkan verir.
 *
 * Array reference type oldugundan RAM-da HEAP bolgede depolanmaqdadir, lakin
 * stackalloc keyword vasitesile STACK-de de hemcinin Array-leri depolaya yerlesdire bilerik.
 *
 * Span string ve array kimi datalarla isleyen zaman emeliyyatlarimizdaki maliyyeti azaldaraq daha cox
 * verimli performans elde etmeyimize imkan yaratmaqdadir.
 *
 *
 * ReadOnlySpan<T> sadece oxuna biler deyisdirile bilmez.
 *
 *
 * Span ile arraySegmenet , stringSegment arasindaki ferqler :
 *
 * ArraySegment sadece array-lerde ,stringSegment sadece string-de emeliyyatlar ucun nezerde tutulub,
 * ve yalniz HEAP bolgeni temsil edirler,
 * ArraySegment-le teyin edilen referans edilen bolgeye mudaxile oluna biler ReadOnlySpan-de mumkun deyil
 *
 * Span ref struct olaraq yaradilmis bir struct-dir
 *
 * HEAP-de allocation edile bilmir, object, dynamic ve yaxud interface type-lari vasitesile reference
 * edile bilmir, class icerisinde field veya property ola bilmez
 *
 * ** Memory type ise Span-nin qisitlamarindan azad bir type-dir.
 */

#region span

int[] numbers = {10, 20, 30, 40, 50, 60, 70, 80, 90};

Span<int> span1 = numbers;
Span<int> span2 = new Span<int>(numbers);
Span<int> span3 = new Span<int>(numbers);
Span<int> span4 = new Span<int>(numbers,0,4);
Span<int> span5 = numbers.AsSpan(0,2);

/*
 * Elimizdeki string dataya reference ederken bize ReadOnlySpan<char> olaraq geri donderir
 */
string text = "Sana sevdanin yollari bana kursunlar...";

ReadOnlySpan<char> readOnlySpan = text.AsSpan();
#endregion
#endregion
