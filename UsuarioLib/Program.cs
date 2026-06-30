using UsuarioLib;

Usuario usuario =
    new Usuario(
        "Luiz",
        "luizgabrielsnogueira@gmail.com",
        new List<string>() { "99550157", "985313235" });

usuario.ExibeTelefones();
usuario.PadronizaTelefones();
usuario.ExibeTelefones();