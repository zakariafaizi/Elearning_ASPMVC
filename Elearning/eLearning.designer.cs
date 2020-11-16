﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elearning
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class eLearningDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEtudiant(Etudiant instance);
    partial void UpdateEtudiant(Etudiant instance);
    partial void DeleteEtudiant(Etudiant instance);
    partial void InsertCour(Cour instance);
    partial void UpdateCour(Cour instance);
    partial void DeleteCour(Cour instance);
    partial void InsertEnseignant(Enseignant instance);
    partial void UpdateEnseignant(Enseignant instance);
    partial void DeleteEnseignant(Enseignant instance);
    partial void InsertInscriCour(InscriCour instance);
    partial void UpdateInscriCour(InscriCour instance);
    partial void DeleteInscriCour(InscriCour instance);
    #endregion
		
		public eLearningDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public eLearningDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public eLearningDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public eLearningDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public eLearningDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Etudiant> Etudiants
		{
			get
			{
				return this.GetTable<Etudiant>();
			}
		}
		
		public System.Data.Linq.Table<Niveau> Niveaus
		{
			get
			{
				return this.GetTable<Niveau>();
			}
		}
		
		public System.Data.Linq.Table<Cour> Cours
		{
			get
			{
				return this.GetTable<Cour>();
			}
		}
		
		public System.Data.Linq.Table<Enseignant> Enseignants
		{
			get
			{
				return this.GetTable<Enseignant>();
			}
		}
		
		public System.Data.Linq.Table<InscriCour> InscriCours
		{
			get
			{
				return this.GetTable<InscriCour>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Etudiant")]
	public partial class Etudiant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idEtudiant;
		
		private string _Nom;
		
		private string _Prenom;
		
		private System.Nullable<int> _Age;
		
		private string _Email;
		
		private string _Niveau;
		
		private string _Username;
		
		private string _Password;
		
		private int _changedpw;
		
		private EntitySet<InscriCour> _InscriCours;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidEtudiantChanging(int value);
    partial void OnidEtudiantChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnPrenomChanging(string value);
    partial void OnPrenomChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnNiveauChanging(string value);
    partial void OnNiveauChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnchangedpwChanging(int value);
    partial void OnchangedpwChanged();
    #endregion
		
		public Etudiant()
		{
			this._InscriCours = new EntitySet<InscriCour>(new Action<InscriCour>(this.attach_InscriCours), new Action<InscriCour>(this.detach_InscriCours));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEtudiant", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idEtudiant
		{
			get
			{
				return this._idEtudiant;
			}
			set
			{
				if ((this._idEtudiant != value))
				{
					this.OnidEtudiantChanging(value);
					this.SendPropertyChanging();
					this._idEtudiant = value;
					this.SendPropertyChanged("idEtudiant");
					this.OnidEtudiantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50)")]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="NVarChar(50)")]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this.OnPrenomChanging(value);
					this.SendPropertyChanging();
					this._Prenom = value;
					this.SendPropertyChanged("Prenom");
					this.OnPrenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Niveau", DbType="NVarChar(50)")]
		public string Niveau
		{
			get
			{
				return this._Niveau;
			}
			set
			{
				if ((this._Niveau != value))
				{
					this.OnNiveauChanging(value);
					this.SendPropertyChanging();
					this._Niveau = value;
					this.SendPropertyChanged("Niveau");
					this.OnNiveauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_changedpw", DbType="Int NOT NULL")]
		public int changedpw
		{
			get
			{
				return this._changedpw;
			}
			set
			{
				if ((this._changedpw != value))
				{
					this.OnchangedpwChanging(value);
					this.SendPropertyChanging();
					this._changedpw = value;
					this.SendPropertyChanged("changedpw");
					this.OnchangedpwChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Etudiant_InscriCour", Storage="_InscriCours", ThisKey="idEtudiant", OtherKey="idEtudiant")]
		public EntitySet<InscriCour> InscriCours
		{
			get
			{
				return this._InscriCours;
			}
			set
			{
				this._InscriCours.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_InscriCours(InscriCour entity)
		{
			this.SendPropertyChanging();
			entity.Etudiant = this;
		}
		
		private void detach_InscriCours(InscriCour entity)
		{
			this.SendPropertyChanging();
			entity.Etudiant = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Niveau")]
	public partial class Niveau
	{
		
		private int _idNiveau;
		
		private string _niveau1;
		
		public Niveau()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idNiveau", DbType="Int NOT NULL")]
		public int idNiveau
		{
			get
			{
				return this._idNiveau;
			}
			set
			{
				if ((this._idNiveau != value))
				{
					this._idNiveau = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="niveau", Storage="_niveau1", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string niveau1
		{
			get
			{
				return this._niveau1;
			}
			set
			{
				if ((this._niveau1 != value))
				{
					this._niveau1 = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cours")]
	public partial class Cour : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idCours;
		
		private string _Nom;
		
		private string _Laboratoire;
		
		private string _Exercice;
		
		private string _Quiz;
		
		private string _Video;
		
		private string _Niveau;
		
		private string _NotesDeCours;
		
		private System.Nullable<int> _idEnseignant;
		
		private EntitySet<Enseignant> _Enseignants;
		
		private EntitySet<InscriCour> _InscriCours;
		
		private EntityRef<Enseignant> _Enseignant;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCoursChanging(int value);
    partial void OnidCoursChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnLaboratoireChanging(string value);
    partial void OnLaboratoireChanged();
    partial void OnExerciceChanging(string value);
    partial void OnExerciceChanged();
    partial void OnQuizChanging(string value);
    partial void OnQuizChanged();
    partial void OnVideoChanging(string value);
    partial void OnVideoChanged();
    partial void OnNiveauChanging(string value);
    partial void OnNiveauChanged();
    partial void OnNotesDeCoursChanging(string value);
    partial void OnNotesDeCoursChanged();
    partial void OnidEnseignantChanging(System.Nullable<int> value);
    partial void OnidEnseignantChanged();
    #endregion
		
		public Cour()
		{
			this._Enseignants = new EntitySet<Enseignant>(new Action<Enseignant>(this.attach_Enseignants), new Action<Enseignant>(this.detach_Enseignants));
			this._InscriCours = new EntitySet<InscriCour>(new Action<InscriCour>(this.attach_InscriCours), new Action<InscriCour>(this.detach_InscriCours));
			this._Enseignant = default(EntityRef<Enseignant>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCours", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idCours
		{
			get
			{
				return this._idCours;
			}
			set
			{
				if ((this._idCours != value))
				{
					this.OnidCoursChanging(value);
					this.SendPropertyChanging();
					this._idCours = value;
					this.SendPropertyChanged("idCours");
					this.OnidCoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(20)")]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Laboratoire", DbType="NVarChar(MAX)")]
		public string Laboratoire
		{
			get
			{
				return this._Laboratoire;
			}
			set
			{
				if ((this._Laboratoire != value))
				{
					this.OnLaboratoireChanging(value);
					this.SendPropertyChanging();
					this._Laboratoire = value;
					this.SendPropertyChanged("Laboratoire");
					this.OnLaboratoireChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Exercice", DbType="NVarChar(MAX)")]
		public string Exercice
		{
			get
			{
				return this._Exercice;
			}
			set
			{
				if ((this._Exercice != value))
				{
					this.OnExerciceChanging(value);
					this.SendPropertyChanging();
					this._Exercice = value;
					this.SendPropertyChanged("Exercice");
					this.OnExerciceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quiz", DbType="NVarChar(MAX)")]
		public string Quiz
		{
			get
			{
				return this._Quiz;
			}
			set
			{
				if ((this._Quiz != value))
				{
					this.OnQuizChanging(value);
					this.SendPropertyChanging();
					this._Quiz = value;
					this.SendPropertyChanged("Quiz");
					this.OnQuizChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Video", DbType="NVarChar(MAX)")]
		public string Video
		{
			get
			{
				return this._Video;
			}
			set
			{
				if ((this._Video != value))
				{
					this.OnVideoChanging(value);
					this.SendPropertyChanging();
					this._Video = value;
					this.SendPropertyChanged("Video");
					this.OnVideoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Niveau", DbType="NVarChar(50)")]
		public string Niveau
		{
			get
			{
				return this._Niveau;
			}
			set
			{
				if ((this._Niveau != value))
				{
					this.OnNiveauChanging(value);
					this.SendPropertyChanging();
					this._Niveau = value;
					this.SendPropertyChanged("Niveau");
					this.OnNiveauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NotesDeCours", DbType="NVarChar(50)")]
		public string NotesDeCours
		{
			get
			{
				return this._NotesDeCours;
			}
			set
			{
				if ((this._NotesDeCours != value))
				{
					this.OnNotesDeCoursChanging(value);
					this.SendPropertyChanging();
					this._NotesDeCours = value;
					this.SendPropertyChanged("NotesDeCours");
					this.OnNotesDeCoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEnseignant", DbType="Int")]
		public System.Nullable<int> idEnseignant
		{
			get
			{
				return this._idEnseignant;
			}
			set
			{
				if ((this._idEnseignant != value))
				{
					if (this._Enseignant.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidEnseignantChanging(value);
					this.SendPropertyChanging();
					this._idEnseignant = value;
					this.SendPropertyChanged("idEnseignant");
					this.OnidEnseignantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cour_Enseignant", Storage="_Enseignants", ThisKey="idCours", OtherKey="idCours")]
		public EntitySet<Enseignant> Enseignants
		{
			get
			{
				return this._Enseignants;
			}
			set
			{
				this._Enseignants.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cour_InscriCour", Storage="_InscriCours", ThisKey="idCours", OtherKey="idCours")]
		public EntitySet<InscriCour> InscriCours
		{
			get
			{
				return this._InscriCours;
			}
			set
			{
				this._InscriCours.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Enseignant_Cour", Storage="_Enseignant", ThisKey="idEnseignant", OtherKey="idEnseignant", IsForeignKey=true)]
		public Enseignant Enseignant
		{
			get
			{
				return this._Enseignant.Entity;
			}
			set
			{
				Enseignant previousValue = this._Enseignant.Entity;
				if (((previousValue != value) 
							|| (this._Enseignant.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Enseignant.Entity = null;
						previousValue.Cours.Remove(this);
					}
					this._Enseignant.Entity = value;
					if ((value != null))
					{
						value.Cours.Add(this);
						this._idEnseignant = value.idEnseignant;
					}
					else
					{
						this._idEnseignant = default(Nullable<int>);
					}
					this.SendPropertyChanged("Enseignant");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Enseignants(Enseignant entity)
		{
			this.SendPropertyChanging();
			entity.Cour = this;
		}
		
		private void detach_Enseignants(Enseignant entity)
		{
			this.SendPropertyChanging();
			entity.Cour = null;
		}
		
		private void attach_InscriCours(InscriCour entity)
		{
			this.SendPropertyChanging();
			entity.Cour = this;
		}
		
		private void detach_InscriCours(InscriCour entity)
		{
			this.SendPropertyChanging();
			entity.Cour = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Enseignant")]
	public partial class Enseignant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idEnseignant;
		
		private string _Nom;
		
		private string _Prenom;
		
		private string _Email;
		
		private string _Username;
		
		private string _Password;
		
		private System.Nullable<int> _idCours;
		
		private EntitySet<Cour> _Cours;
		
		private EntityRef<Cour> _Cour;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidEnseignantChanging(int value);
    partial void OnidEnseignantChanged();
    partial void OnNomChanging(string value);
    partial void OnNomChanged();
    partial void OnPrenomChanging(string value);
    partial void OnPrenomChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnidCoursChanging(System.Nullable<int> value);
    partial void OnidCoursChanged();
    #endregion
		
		public Enseignant()
		{
			this._Cours = new EntitySet<Cour>(new Action<Cour>(this.attach_Cours), new Action<Cour>(this.detach_Cours));
			this._Cour = default(EntityRef<Cour>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEnseignant", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idEnseignant
		{
			get
			{
				return this._idEnseignant;
			}
			set
			{
				if ((this._idEnseignant != value))
				{
					this.OnidEnseignantChanging(value);
					this.SendPropertyChanging();
					this._idEnseignant = value;
					this.SendPropertyChanged("idEnseignant");
					this.OnidEnseignantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nom", DbType="NVarChar(50)")]
		public string Nom
		{
			get
			{
				return this._Nom;
			}
			set
			{
				if ((this._Nom != value))
				{
					this.OnNomChanging(value);
					this.SendPropertyChanging();
					this._Nom = value;
					this.SendPropertyChanged("Nom");
					this.OnNomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prenom", DbType="NVarChar(50)")]
		public string Prenom
		{
			get
			{
				return this._Prenom;
			}
			set
			{
				if ((this._Prenom != value))
				{
					this.OnPrenomChanging(value);
					this.SendPropertyChanging();
					this._Prenom = value;
					this.SendPropertyChanged("Prenom");
					this.OnPrenomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCours", DbType="Int")]
		public System.Nullable<int> idCours
		{
			get
			{
				return this._idCours;
			}
			set
			{
				if ((this._idCours != value))
				{
					if (this._Cour.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCoursChanging(value);
					this.SendPropertyChanging();
					this._idCours = value;
					this.SendPropertyChanged("idCours");
					this.OnidCoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Enseignant_Cour", Storage="_Cours", ThisKey="idEnseignant", OtherKey="idEnseignant")]
		public EntitySet<Cour> Cours
		{
			get
			{
				return this._Cours;
			}
			set
			{
				this._Cours.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cour_Enseignant", Storage="_Cour", ThisKey="idCours", OtherKey="idCours", IsForeignKey=true)]
		public Cour Cour
		{
			get
			{
				return this._Cour.Entity;
			}
			set
			{
				Cour previousValue = this._Cour.Entity;
				if (((previousValue != value) 
							|| (this._Cour.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cour.Entity = null;
						previousValue.Enseignants.Remove(this);
					}
					this._Cour.Entity = value;
					if ((value != null))
					{
						value.Enseignants.Add(this);
						this._idCours = value.idCours;
					}
					else
					{
						this._idCours = default(Nullable<int>);
					}
					this.SendPropertyChanged("Cour");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Cours(Cour entity)
		{
			this.SendPropertyChanging();
			entity.Enseignant = this;
		}
		
		private void detach_Cours(Cour entity)
		{
			this.SendPropertyChanging();
			entity.Enseignant = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.InscriCours")]
	public partial class InscriCour : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idInscription;
		
		private System.Nullable<int> _idCours;
		
		private System.Nullable<int> _idEtudiant;
		
		private EntityRef<Cour> _Cour;
		
		private EntityRef<Etudiant> _Etudiant;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidInscriptionChanging(int value);
    partial void OnidInscriptionChanged();
    partial void OnidCoursChanging(System.Nullable<int> value);
    partial void OnidCoursChanged();
    partial void OnidEtudiantChanging(System.Nullable<int> value);
    partial void OnidEtudiantChanged();
    #endregion
		
		public InscriCour()
		{
			this._Cour = default(EntityRef<Cour>);
			this._Etudiant = default(EntityRef<Etudiant>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idInscription", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idInscription
		{
			get
			{
				return this._idInscription;
			}
			set
			{
				if ((this._idInscription != value))
				{
					this.OnidInscriptionChanging(value);
					this.SendPropertyChanging();
					this._idInscription = value;
					this.SendPropertyChanged("idInscription");
					this.OnidInscriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCours", DbType="Int")]
		public System.Nullable<int> idCours
		{
			get
			{
				return this._idCours;
			}
			set
			{
				if ((this._idCours != value))
				{
					if (this._Cour.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidCoursChanging(value);
					this.SendPropertyChanging();
					this._idCours = value;
					this.SendPropertyChanged("idCours");
					this.OnidCoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idEtudiant", DbType="Int")]
		public System.Nullable<int> idEtudiant
		{
			get
			{
				return this._idEtudiant;
			}
			set
			{
				if ((this._idEtudiant != value))
				{
					if (this._Etudiant.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidEtudiantChanging(value);
					this.SendPropertyChanging();
					this._idEtudiant = value;
					this.SendPropertyChanged("idEtudiant");
					this.OnidEtudiantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cour_InscriCour", Storage="_Cour", ThisKey="idCours", OtherKey="idCours", IsForeignKey=true)]
		public Cour Cour
		{
			get
			{
				return this._Cour.Entity;
			}
			set
			{
				Cour previousValue = this._Cour.Entity;
				if (((previousValue != value) 
							|| (this._Cour.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cour.Entity = null;
						previousValue.InscriCours.Remove(this);
					}
					this._Cour.Entity = value;
					if ((value != null))
					{
						value.InscriCours.Add(this);
						this._idCours = value.idCours;
					}
					else
					{
						this._idCours = default(Nullable<int>);
					}
					this.SendPropertyChanged("Cour");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Etudiant_InscriCour", Storage="_Etudiant", ThisKey="idEtudiant", OtherKey="idEtudiant", IsForeignKey=true)]
		public Etudiant Etudiant
		{
			get
			{
				return this._Etudiant.Entity;
			}
			set
			{
				Etudiant previousValue = this._Etudiant.Entity;
				if (((previousValue != value) 
							|| (this._Etudiant.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Etudiant.Entity = null;
						previousValue.InscriCours.Remove(this);
					}
					this._Etudiant.Entity = value;
					if ((value != null))
					{
						value.InscriCours.Add(this);
						this._idEtudiant = value.idEtudiant;
					}
					else
					{
						this._idEtudiant = default(Nullable<int>);
					}
					this.SendPropertyChanged("Etudiant");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
