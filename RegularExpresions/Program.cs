using System;
using System.Text.RegularExpressions;

#region regularExpresions
/*
 * System.Text.RegularExpressions       Regex
 *
 * Regular Expressions string ifadeler uzerinde daha asan emeliyyatlari yerine yetirmeye imkan vermektedir.
 *
 *
 */

#region regular Expressions Operators

#region ^ Operatoru

/*
 *  ^ Operatoru
 *
 *  Egerki setirin basliginin istenilen ifadeyle baslamagina imkan verir.
 *
 * meselen : ^1 ifade mutleq 1-le baslamalidir deyirik.
 */

//string text = "91234aswawsd";

//Regex regex = new Regex("^9");

//Match match = regex.Match(text);

//Console.WriteLine(match.Success);


#endregion

#region \
/*
 * ***** \ : mueyyen xarakter qruplari daxil eden zaman istifade edilir
 *
 * ***** \D : String Ifadedenin mueyyen edilen yerinde  reqem olmayan tek bir
 * xarakterin istifade edilmeli oldugunu bildirir.
 *
 * ***** \d : String Ifadenin mueyyen edilne yerinde 0-9 arasinda tek bir reqem olacagini
 * bildirir.
 *
 * ***** \W : String Ifadenin mueyyen edilen yerinde alfanumeric olmayan xarakter istifade edilmeli
 * oldugunu bilidir. yeni simvollar. Alfanumeric : a-z A-Z 0-9 nezerde tutulur.
 *
 * ***** \w : String Ifadenin mueyyen edilen yerinde alfanumeric ifadenin olacagini bildirir.
 *
 * ***** \S : String Ifadenin  ueyyen edilen yerinde bosluq xarakterleri (tab/space) istisna
 *  her hansisa bir xarakterin ola bileceyini bildirir.
 *
 * ***** \s : String ifadenin mueyyen edilen yerinde sadece bosluq olacagini bildirir,
 */

// example 25 ile baslayan , ucuncu xarakteri her hansisa bir reqem olan  ve son xarakteri de bosluq
// olmayan bir ifade yazin.
//
// [^25\d\S] ^25 - 25 baslayir, \d -  0-9 arasi reqemler, \S - bosluq olmasin

//string text = "258976234a";
//Regex regex = new Regex(@"[^9\d\S]");


#endregion

#region + 
/*
 * Bildirilen qrupdaki xarakterlerin  bir ve ya daha cox olmasini istediyimiz veziyyetlerde
 * istifade ede bilerik.
 *
 * example :
 * 994 ile baslayan , arada reqem olan  ve son xarakteri de bosluq  // ^994\d+\S
 * olmayan bir ifade yazin.
 *
 * \d tekce bir xarakteri reqem olaraq gozlediyi halda \d+ + operatou ile birlikde bir ve
 * birden cox reqem ola bileceyini bildirir.
 */


#endregion

#region | ve ya
/*
 *  bas herfi a ve ya b ve ya c olan ad daxil edin.
 *
 *  a|b|c
 */


#endregion

#region {n}
/*
 * n sayda n qeder xarakter istifade eden zaman
 *
 * 994-506856915 ^994-\d{9}
 *
 *
 */


#endregion

#region ?
/*
 * ? ozunden qabaq olan xarakterin ifademizde en cox 1 defe olacagini temsil edir,
 * ifade de olmazsada problem deyil deyir anlayislidir.
 *
 *
 * \d{3}0?1 => 12301 , 34501, 6781(arada yeni 0 olmayada biler amma olsaydi sadece birdefe ola bilerdi)
 */


#endregion

#region .
/*
 * mueyyen edilen yerinde istifade edilerken  \n xarakteri istisna olmaqla
 *  her hansi bir xarakter istifade edile biler.
 *
 * \d{3}.0 => 994+0, 994*0, 234A0
 */


#endregion

#region \b \B
/*
 * \B ifadenin basinda ve ya sonunda olmamasin lazim olan xarakterler ucun
 * \b ifadenin sonun mueyyen edilen xarakterlerle biteceyini bildirir
 *
 * \d{3}dir\B  => dir\B - basinda veya sonunda dir yazila bilmez demekdir. 
 */



#endregion

#region [n]
/*
 *  xarakter araligi teyin edile bilir,
 *  special xarakterlerin yerinde yazilamasini ifade edir.
 *
 * \d{3}[A-E]  - A-E ile arasinda herfleri xarakterleri qebul edir ozleride daxil
 *
 * + (994) 50 685 6915 =>  [+(]994[)]-\d{9}
 */

Regex regex = new Regex(@"[(]\d{3}[)]\s\d{2}\s\d{3}\s\d{4}");

#endregion
#endregion


#endregion
