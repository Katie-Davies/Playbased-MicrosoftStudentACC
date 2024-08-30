import { useMutation, useQueryClient } from '@tanstack/react-query'
import { User } from '../models/models'

import { createUser } from '../apis/apiClient'

export default function useCreateUser() {
  const queryClient = useQueryClient()
  return useMutation({
    mutationFn: async (values: User) => createUser(values),
    onSuccess: () => {
      queryClient.invalidateQueries({ queryKey: ['user'] })
    },
  })
}
