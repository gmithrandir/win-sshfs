WinSSHFS
========================

Fork of Martin Dimov's WinSSHFS project. Removes the GUI, exposes clean library interface, adds a CLI.

CLI usage is:

```
SSHFS 1.0.0.0
Copyright c  2017

  -d, --drive-letter    Required. Drive letter to mount the remote SFTP path
                        under

  -r, --path            Required. Absolute path of directory to be mounted from
                        remote system

  -h, --host            Required. IP or hostname of remote host

  -p, --port            (Default: 22) SSH service port on remote server

  -u, --username        Required. Name of SSH user on remote system

  -x, --password        SSH user's password, if password-based or
                        keyboard-interactive auth should be attempted

  -k, --private-keys    SSH user's private key(s), if key-based auth should be
                        attempted
```

Builds can be found on the [releases page](https://github.com/masaeedu/win-sshfs/releases/latest)

