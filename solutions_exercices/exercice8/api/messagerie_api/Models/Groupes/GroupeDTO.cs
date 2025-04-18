﻿using messagerie_api.OpenApi;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace messagerie_api.Models.Groupes;

public class GroupeDTO {
    [Required]
    [Description("L'identifiant unique du groupe.")]
    [Example("1")]
    public long Id { get; set; }

    [Required]
    [Description("Le nom du groupe")]
    [MaxLength(255)]
    [MinLength(1)]
    [Example("Les invincibles")]
    public string Nom { get; set; }

    [Required]
    [Description("L'identifiant unique de l'utilisateur ayant créé le groupe. Correspond au user_id d'Auth0")]
    [Example("auth0|67bf4268e6c019494585e130")]
    public string CreateurId { get; set; }

    public GroupeDTO(Groupe groupe) {
        Id = groupe.Id;
        Nom = groupe.Nom;
        CreateurId = groupe.CreateurId;
    }
}
