﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCC.Application.Messagem {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MsgNotification {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MsgNotification() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TCC.Application.Messagem.MsgNotification", typeof(MsgNotification).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Complete seus dados, criando sua nova Empresa..
        /// </summary>
        public static string CreateCompany {
            get {
                return ResourceManager.GetString("CreateCompany", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Cadastre uma matriz para continuar.
        /// </summary>
        public static string MatrizErro {
            get {
                return ResourceManager.GetString("MatrizErro", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Não existem colaboradores Alocados verifique a sua estrutura organizacional..
        /// </summary>
        public static string NaoExistemColaboradoresAlocados {
            get {
                return ResourceManager.GetString("NaoExistemColaboradoresAlocados", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Já existe um Termo cadastrado para esta empresa. Verifique na lista de termos..
        /// </summary>
        public static string TermoCadastrado {
            get {
                return ResourceManager.GetString("TermoCadastrado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Já existe um Termo cadastrado para esta empresa com esta Política. Verifique na lista de termos..
        /// </summary>
        public static string TermoCadastradoParaEstaPolitica {
            get {
                return ResourceManager.GetString("TermoCadastradoParaEstaPolitica", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Confirmação de leitura realizada com sucesso..
        /// </summary>
        public static string TermoConfirmacao {
            get {
                return ResourceManager.GetString("TermoConfirmacao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Este usuário não está alocado para realizar o treinamento..
        /// </summary>
        public static string UsuarioNaoAlocado {
            get {
                return ResourceManager.GetString("UsuarioNaoAlocado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Este Usuário é um Administrador ou não está cadastrado como Colaborador..
        /// </summary>
        public static string UsuarioNaoCadastradoComoColaborador {
            get {
                return ResourceManager.GetString("UsuarioNaoCadastradoComoColaborador", resourceCulture);
            }
        }
    }
}
