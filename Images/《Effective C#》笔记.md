## 1. Use Properties Instead of Accessible Data Members 

- is far easier to change
- multithreaded
- can be virtual
- can define a property in an interface, and *Field* can't
- different accessibility
- *indexer*
  - multidemensional indexer
  - use an indexer for sequences or dictionaries



## 2. Prefer *readonly* to *const*

- *runtime constants*: slower and correct
- *compile-time constants*: faster but maybe broken program
- Prefer *runtime constants* To *compile-time constants*
- *runtime constants*: more flexibility and can be any type



## 3. Prefer the *is* or *as* Operators to Casts

- safer
- more efficient at runtime



## 4. Use Conditional Attributes Instead of *#if* 

- must have a return type of *void*
- more efficient
- only use at function level, which forces you to better structure your code



## 5. Always Provide *ToString()* 

- also can create different forms of string output 



## 6. Understand the Relationships Among the Many Different Concepts of Equality    

- C# provides four different functions:
  - public static bool **ReferenceEquals** (object left, object right);
  - public static bool **Equals** (object left, object right);
  - public virtual bool **Equals**(object right);
  - public static bool operator **==** (MyClass left, MyClass right);
- never redefine *Object.ReferenceEquals()*
  - *ReferenceEquals()* always returns false when you use it to test equality for *value types*. 
  - Even when you compare a value type to itself, *ReferenceEquals()* returns false. This is due to **boxing**
- never redefine *Object.Equals()* 
  - *Object.Equals (object left, object right)* Invokes *Equals (object right)*
- override instance *Equals()* and *operator==()* for *value types* to provide better performance. 
- override instance *Equals()* for *reference types*





















