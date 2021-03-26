#!/usr/bin/env python3
# -*- coding: utf-8 -*-

import os

def main():
    local_path = os.getcwd()

    files = []
    folders = []
    for root, _, file in os.walk(local_path):
        for f in file:
            if f.endswith('.cs'):
                os.remove(os.path.join(root, f))
                continue
            if not f.endswith('.proto'):
                continue
            if root not in folders:
                folders.append(root)
            files.append(os.path.join(root, f))

    include = ''
    for p in folders:
        include += '-I' + p + ' '

    for p in files:
        command = './protoc ' + include + ' --csharp_out=' + os.path.dirname(p) + ' ' + p
        print(command)
        os.system(command)

    print('Done')


if __name__ == "__main__":
    main()
