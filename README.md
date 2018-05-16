# HashMaps

# A program that will read in a file containing a series of items with weight and gold piece values. Each item is stored into a created HashMap.

# Classes
# Item Class
It Contains the name, value, and weight of the found item (how much the item is worth in gold pieces). An Item object is used as the generic Value V in the Entry / HashMap classes. An item must be comparable with other Items based on the name. Items with ALL the same properties will return as equal (Name/Gold/Weight).

# StringKey Class
StringKey Class contains a String KeyName property used to make a hash value. A StringKey object is used as the generic Key K in the Entry/HashMap classes.This class overrides the object hashCode() method and return a hash code based on an KeyName. The object equals() method is overridden where StringKeys with the same KeyName property will return as equal.

# Map Interface

# Entry<K, V> Class 
The generics: K (key) and V (value) are read only properties.These two properties are only manipulated in the constructor. The Item’s name will be stored inside of StringKey as the Key, while the Value will be an Item object

# HashMap<K, V> Class
The hashMap class implements the Map interface. The default CAPACITY is 11, default LOAD_FACTOR is 0.75 (75%). The HashMap automatically extends when the threshold (current capacity * load factor) is exceeded.The new size after extending must be the closest prime integer value greater than twice the current capacity (see theory slides for details on this algorithm). Collisions are handled using: linear probing.

# Adventure Class
 This class will read in a file containing the ItemData.txt. The file path and name is passed to a constructor, which will continue to loop through each line of the ItemData.txt. Each item will be put() into the hash map and a method called PrintLootMap() will print all of the data stored in the hash map: the Key and associated Value.






