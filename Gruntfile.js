module.exports = function(grunt) {
	grunt.initConfig({
		watch: {
			csx: {
				files: [ "**/**.csx"],
				tasks: ["shell"]
			}
		},
		shell: {
			runTest: {
				command: "scriptcs TestDb.csx -debug"
			}
		}
	});

	grunt.loadNpmTasks("grunt-contrib-watch");
	grunt.loadNpmTasks("grunt-shell");
	grunt.registerTask("default", ["shell", "watch"]);
};