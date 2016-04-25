var gulp = require("gulp");
var concat = require("gulp-concat");
var uglify = require("gulp-uglify");
var rename = require("gulp-rename");
var debug = require("gulp-debug");
var path = require("path");

// /**/ - любая вложенная папка
// *.js - любой js файл

var source = path.join(__dirname, "Scripts/**/*.js");
var compile = path.join(__dirname, "wwwroot");
var output = "app.js";

gulp.task("build-scripts", function () {
    return gulp.src(source)
        .pipe(concat(output, { newLine: ";" })) // newline - добавляет ; в конец каждого файла
        .pipe(uglify({
            compress: {
                drop_debugger: true,
                drop_console: true
            }
        }))
        .pipe(rename({
            suffix: ".min"
        }))
        
        .pipe(gulp.dest(compile));
});

gulp.task("watch", ["build-scripts"], function () {
    gulp.watch(source, ["build-scripts"]).on("change", function (file) {
        console.log("script", file.path);
    });
});

gulp.task("default", ["build-scripts"]);