#r "E:\\source\\projects\\tnt\\UploadManager2\\bin\\Debug\\UploadManager.exe"
#r "E:\\source\\projects\\tnt\\UploadManager2\\bin\\Debug\\Extensions\\UMTNTPlugin.dll"

using System.IO;
using ScriptCs.NUnit;
using UploadManager.Settings;
using UMTNTPlugin.Utility;
using UMTNTPlugin.Models;

class CC {
	public static String GetConnectionString() {
		var accessPath = "E:\\implements\\TNT\\edoc.mdb";
		var connection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + accessPath;
		return connection;
	}
}

[TestFixture]
public class Tests {

	private DB _db = null;

	[SetUp]
	public void Init() {
		_db = LoadDb();
	}

	public DB LoadDb() {
		var setting = new AppSettings();
		var db = new DB(setting);
		var conn = CC.GetConnectionString();
		db.SetConnectionString(conn);
		return db;
	}

	[Test]
	public void TestUnitTest() {
		Assert.AreEqual(0, 0);
		Assert.AreEqual(true, true);
	}

	[Test]
	public void TestGruntShell() {
		Assert.NotNull("Save OK?");
	}

	[Test]
	public void TestQuery() {
		var rs = _db.QueryByConAndDepot(454005846, "ABX");
		Assert.AreEqual(rs.ConNumber, 454005846);
		Assert.AreEqual(rs.Depot, "ABX");
		Assert.AreEqual(rs.AccountCode, "020262119");
	}
}

public void Start() {
	var unit = Require<NUnitRunner>();
	unit.RunAllUnitTests();
}

Start();