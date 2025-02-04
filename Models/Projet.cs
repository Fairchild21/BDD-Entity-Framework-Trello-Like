﻿using System;
using System.Collections.Generic;

namespace BDD_Trello.Models;

public partial class Projet
{
    public int IdProjet { get; set; }

    public string? Nom { get; set; }

    public string? Description { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual List<Liste> Listes { get; } = new List<Liste>();

    public virtual List<UtilisateurProjet> UtilisateurProjets { get; } = new List<UtilisateurProjet>();

    public Projet()
    {
        this.IdProjet = 0;
    }

    public Projet(string nom, string description, DateTime dateCreation)
    {
        this.IdProjet = 0;
        this.Nom = nom;
        this.Description =description;
        this.DateCreation = dateCreation;
        
    }

    public void changeNom(string nouveauNom)
    {
        Nom = nouveauNom;
    }

    public void changeDescription(string nouvelleDescription)
    {
        Description = nouvelleDescription;
    }

    public void addList(Liste liste)
    {
        Listes.Add(liste);
        liste.IdProjetNavigation = this;
    }

    // public void AddUtilsiateur(Utilisateur utilisateur)
    // {
    //     utilisateur.
    // }


}
