// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from Test on 2014-04-09 20:21:56Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace Example1.DbLinq
{
	using System;
	using System.ComponentModel;
	using System.Data;
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	
	
	public partial class TestContext : DataContext
	{
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
		
		
		public TestContext(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public TestContext(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
		
		public TestContext(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public TestContext(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<Articles> Articles
		{
			get
			{
				return this.GetTable <Articles>();
			}
		}
		
		public Table<Users> Users
		{
			get
			{
				return this.GetTable <Users>();
			}
		}
	}
	
	[Table(Name="test.Articles")]
	public partial class Articles : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _creationDate;
		
		private int _id;
		
		private byte[] _text;
		
		private int _usersID;
		
		private EntityRef<Users> _users = new EntityRef<Users>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreationDateChanged();
		
		partial void OnCreationDateChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnTextChanged();
		
		partial void OnTextChanging(byte[] value);
		
		partial void OnUsersIDChanged();
		
		partial void OnUsersIDChanging(int value);
		#endregion
		
		
		public Articles()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_creationDate", Name="CreationDate", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreationDate
		{
			get
			{
				return this._creationDate;
			}
			set
			{
				if ((_creationDate != value))
				{
					this.OnCreationDateChanging(value);
					this.SendPropertyChanging();
					this._creationDate = value;
					this.SendPropertyChanged("CreationDate");
					this.OnCreationDateChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="Id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_text", Name="Text", DbType="mediumblob", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public byte[] Text
		{
			get
			{
				return this._text;
			}
			set
			{
				if (((_text == value) == false))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[Column(Storage="_usersID", Name="Users_Id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int UsersID
		{
			get
			{
				return this._usersID;
			}
			set
			{
				if ((_usersID != value))
				{
					this.OnUsersIDChanging(value);
					this.SendPropertyChanging();
					this._usersID = value;
					this.SendPropertyChanged("UsersID");
					this.OnUsersIDChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_users", OtherKey="ID", ThisKey="UsersID", Name="fk_Articles_Users", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public Users Users
		{
			get
			{
				return this._users.Entity;
			}
			set
			{
				if (((this._users.Entity == value) == false))
				{
					if ((this._users.Entity != null))
					{
						Users previousUsers = this._users.Entity;
						this._users.Entity = null;
						previousUsers.Articles.Remove(this);
					}
					this._users.Entity = value;
					if ((value != null))
					{
						value.Articles.Add(this);
						_usersID = value.ID;
					}
					else
					{
						_usersID = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="test.Users")]
	public partial class Users : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createTime;
		
		private string _email;
		
		private string _firstName;
		
		private int _id;
		
		private string _lastName;
		
		private string _password;
		
		private EntitySet<Articles> _articles;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreateTimeChanged();
		
		partial void OnCreateTimeChanging(System.DateTime value);
		
		partial void OnEmailChanged();
		
		partial void OnEmailChanging(string value);
		
		partial void OnFirstNameChanged();
		
		partial void OnFirstNameChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(int value);
		
		partial void OnLastNameChanged();
		
		partial void OnLastNameChanging(string value);
		
		partial void OnPasswordChanged();
		
		partial void OnPasswordChanging(string value);
		#endregion
		
		
		public Users()
		{
			_articles = new EntitySet<Articles>(new Action<Articles>(this.Articles_Attach), new Action<Articles>(this.Articles_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_createTime", Name="create_time", DbType="timestamp", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreateTime
		{
			get
			{
				return this._createTime;
			}
			set
			{
				if ((_createTime != value))
				{
					this.OnCreateTimeChanging(value);
					this.SendPropertyChanging();
					this._createTime = value;
					this.SendPropertyChanged("CreateTime");
					this.OnCreateTimeChanged();
				}
			}
		}
		
		[Column(Storage="_email", Name="email", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				if (((_email == value) == false))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[Column(Storage="_firstName", Name="FirstName", DbType="varchar(30)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string FirstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if (((_firstName == value) == false))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._firstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="Id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_lastName", Name="LastName", DbType="varchar(30)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string LastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if (((_lastName == value) == false))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[Column(Storage="_password", Name="password", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Password
		{
			get
			{
				return this._password;
			}
			set
			{
				if (((_password == value) == false))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_articles", OtherKey="UsersID", ThisKey="ID", Name="fk_Articles_Users")]
		[DebuggerNonUserCode()]
		public EntitySet<Articles> Articles
		{
			get
			{
				return this._articles;
			}
			set
			{
				this._articles = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void Articles_Attach(Articles entity)
		{
			this.SendPropertyChanging();
			entity.Users = this;
		}
		
		private void Articles_Detach(Articles entity)
		{
			this.SendPropertyChanging();
			entity.Users = null;
		}
		#endregion
	}
}
