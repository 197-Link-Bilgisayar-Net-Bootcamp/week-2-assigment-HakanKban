/* Barbara Liskov’un ortaya attığı bu prensibe göre ;
 * üst sınıf ile alt sınıf arasında davranış olarak hiçbir fark olmamalıdır. 
 * Yani birbirlerinin yerine kullanılabilmelidirler.
 * Base classlar kalıtım veren sınıflar, derived classlardaki işlevselliği tam olarak yerine getirdiğinden emin olmalıyız.
 * Bir sınıfta bulunan herhangi bir işlev, kendisinden kalıtım alan sınıflarda kullanılmayacaksa eğer 
 * işte bu durum LSP’ye aykırı bir durumdur.
 */