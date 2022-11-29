{ pkgs ? import (
  builtins.fetchTarball {
    url = "https://github.com/nixos/nixpkgs/archive/22.05.tar.gz";
    sha256 = "0d643wp3l77hv2pmg2fi7vyxn4rwy0iyr8djcw1h5x72315ck9ik";
  }
) {} }:

with pkgs;

let 
  python-with-my-packages = python3.withPackages (p: with p; [
    virtualenv
  ]);
in 
mkShell {
  buildInputs = [
    cmake
    gdb
    gcc
    gnumake
    ninja
    python-with-my-packages
  ];

  shellHook = ''
    [ ! -d venv ] && python -m virtualenv venv
    source venv/bin/activate
    pip install conan==1.54.0
  '';
}
