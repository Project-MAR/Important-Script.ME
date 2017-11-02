  - protected defines class members which are not visible to users of the class (those who initialize and use it), but are visible to all inheriting classes (descendants).
  - protected internal defines class members which are both internal, i.e. visible within the entire assembly, and protected, i.e. not visible outside the assembly, but visible to classes who inherit it (even outside the assembly).
   
When a base class is inherited: 
  - All of its public, protected and protected internal members (methods, properties, etc.) are visible to the inheriting class.      
  - All of its private methods, properties and member-variables are not visible to the inheriting class.
  - All of its internal members are visible to the inheriting class, only if the base class and the inheriting class are in the same assembly (the same Visual Studio project).
