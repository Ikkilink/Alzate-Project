using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSpawnEnemies
{
    public Enemy[] enemies = new Enemy[2];
    void CreateEnemies()
    {
        enemies[0] = new Zombie();
        enemies[1] = new Vampire();
    }


    // Gestionar el danio al enemigo
    void DamageEnemy()
    {
        enemies[0].Damage();
    }
}

public class Enemy
{
    public virtual void Caminar()
    {
        
    }

    public void Damage()
    {

    }

}

public class Zombie : Enemy
{
    
}

public class Vampire : Enemy
{

}






public class Zoo
{
    INadar[] objetosQueSabenNadar;
    
    void HacerNadar()
    {
        for (int indexInterface = 0; indexInterface < objetosQueSabenNadar.Length; indexInterface++)
        {
            objetosQueSabenNadar[indexInterface].Nadar();
        }
    }
}


public class Animal
{

}

public class AnimalTerrestre : Animal
{

}

public class Perro : AnimalTerrestre, INadar, ISaltar
{
    public void Nadar()
    {
        
    }

    public void Saltar()
    {
        
    }
}

public class AnimalAcuatico : Animal, INadar
{
    public void Nadar() {}
}

public class AnimalAereo
{

}

public interface INadar
{
    void Nadar();
}

public interface ISaltar
{
    void Saltar();
}