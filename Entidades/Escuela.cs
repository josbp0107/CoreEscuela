namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre; // Atributo de la entidad Escuela
        
        //Atributo Nombre encapsulado con sus diferentes modificadores de acceso
        public string Nombre  
        {
            get{ return nombre; }
            set{ nombre = value.ToUpper(); }
        }

        public int AñoDeCreacion{ get;set; } //Modificadores de acceso encapsulados
        public string Pais { get; set; }  
        public string Ciudad { get; set; }
        public TiposEscuela TipoEscuela{ get;set; }

        public Curso[] Cursos { get; set; }

        /*
            Metodo constructor de la clase Escuela 
            @Param string nombre atributo de la entidad Escuela 
            @param int año atributo de la entidad Escuela
        */

        // public Escuela(string nombre, int año)
        // {
        //     this.nombre = nombre;
        //     AñoDeCreacion = año;
        // }

        // Otra manera de crear constructor de una clase
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año); //Igualación por tuplas
        
        public Escuela(string nombre, int año, TiposEscuela tipos, string pais="", string ciudad="")
        {   
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }
        
        
        public override string ToString() //Metodo para sobreescribir el objeto Escuela a String
        {
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad}";
        }
           
    }
}