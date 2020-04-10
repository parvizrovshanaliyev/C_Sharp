using System;

namespace CSharp.DesignPatterns.AbstractFactory {
    class Program {
        static void Main (string[] args) {

            // step 6 run run 
            Creater create = new Creater (new SqlDatabase ());
            Console.WriteLine ("**********");
            create = new Creater (new MySqlDatabase ());
            Console.Read ();
        }
    }

    // step 1 ##################################################
    // Abstract Product
    abstract class Connection {
        public abstract bool Connect ();
        public abstract bool DisConnect ();
        public abstract string State { get; }
    }


    // Abstract Product
    abstract class Command {
        public abstract void Execute (string query);
    }

    // step 2 ####################################################
    // Concrete Product
    class SqlConnection : Connection {
        public override string State => "Open";

        public override bool Connect () {
            System.Console.WriteLine ("SqlConnection connected");
            return true;
        }

        public override bool DisConnect () {
            System.Console.WriteLine ("SqlConnection disConnected.");
            return false;
        }
    }

    // Concrete Product
    class SqlCommand : Command {
        public override void Execute (string query) =>
            System.Console.WriteLine ("SqlCommand query running.");
    }

    // Concrete Product
    class MySqlConnection : Connection {
        public override string State => "Open";

        public override bool Connect () {
            System.Console.WriteLine ("MySqlConnection connected");
            return true;
        }

        public override bool DisConnect () {
            System.Console.WriteLine ("MySqlConnection disConnected.");
            return false;
        }
    }

    // Concrete Product
    class MySqlCommand : Command {
        public override void Execute (string query) =>
            System.Console.WriteLine ("MySqlCommand query running.");
    }

    // step 3 ###########################################################
    //Abstract Factory
    abstract class DatabaseFactory {
        public abstract Connection CreateConnection ();
        public abstract Command CreateCommand ();
    }
    // step 4 ###########################################################
    //Concreate Factory
    class SqlDatabase : DatabaseFactory {
        public override Command CreateCommand () => new SqlCommand ();
        public override Connection CreateConnection () => new SqlConnection ();
    }

    //Concreate Factory
    class MySqlDatabase : DatabaseFactory {
        public override Command CreateCommand () => new MySqlCommand ();
        public override Connection CreateConnection () => new MySqlConnection ();
    }

    // step 5 ###########################################################
    //Creater
    class Creater {
        DatabaseFactory _databaseFactory;
        Connection _connection;
        Command _command;
        public Creater (DatabaseFactory databaseFactory) {
            _databaseFactory = databaseFactory;
            _connection = _databaseFactory.CreateConnection ();
            _command = _databaseFactory.CreateCommand ();

            Start ();
        }

        void Start () {
            if (_connection.State == "Open") {
                _connection.Connect ();
                _command.Execute ("Select * from...");
                _connection.DisConnect ();
            }
        }
    }

    // step 6 ######################################################
}